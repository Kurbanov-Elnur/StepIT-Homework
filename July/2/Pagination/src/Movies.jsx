import React, { useRef, useState, useEffect } from 'react';
import axios from 'axios';

function Movies(props) {
    const [movies, setMovies] = useState([]);
    const [pages, setPages] = useState(1);
    const [currentPage, setCurrentPage] = useState(1);

    const handlePageClick = (page) => {
        setCurrentPage(page);
    };

    const goToPreviousPage = () => {
        setCurrentPage((prevPage) => prevPage - 1);
    };

    const goToNextPage = () => {
        setCurrentPage((prevPage) => prevPage + 1);
    };

    useEffect(() => {
        getMoviesByName();
    }, [currentPage]);

    const searchInput = useRef();

    const getMoviesByName = () => {
        const options = {
            method: 'GET',
            url: 'https://api.themoviedb.org/3/search/movie',
            params: {
                query: searchInput.current.value,
                include_adult: 'false',
                language: 'en-US',
                page: currentPage
            },
            headers: {
                accept: 'application/json',
                Authorization: 'Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIyYTcxYWMxNTc3NzdkZTM3YzIxNTFjY2Q3OTQxZjU1YSIsIm5iZiI6MTcyMDUwMjA3MC45MjY0NDksInN1YiI6IjY1MzIyMzVkOWFjNTM1MDg3NzU2MGEzYyIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.mqkmoezVNNZ1BkrxKOEfaIPS6H6JNYxxH6ifM-bvuA8'
            }
        };

        axios.request(options)
            .then(function (response) {
                setMovies(response.data.results);
                setPages(response.data.total_pages);
            })
            .catch(function (error) {
                console.error(error);
            });
    };

    return (
        <div style={{ maxWidth: '700px', margin: '50px auto 0 auto' }}>
            <div className="flex items-center">
                <label htmlFor="voice-search" className="sr-only">Search</label>
                <div className="relative w-full">
                    <div className="flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none">
                        <svg aria-hidden="true" className="w-5 h-5 text-gray-500 dark:text-gray-400" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                            <path fillRule="evenodd" d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z" clipRule="evenodd"></path>
                        </svg>
                    </div>
                    <input ref={searchInput} type="text" id="voice-search" className="bg-gray-50 border border-gray-300 text-gray-900 text-sm focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Search Movies..." required />
                    <button type="button" onClick={getMoviesByName} className="flex absolute inset-y-0 right-0 items-center pr-3">
                        <svg aria-hidden="true" className="w-4 h-4 text-gray-500 dark:text-gray-400 hover:text-gray-900 dark:hover:text-white" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                            <path fillRule="evenodd" d="M7 4a3 3 0 016 0v4a3 3 0 11-6 0V4zm4 10.93A7.001 7.001 0 0017 8a1 1 0 10-2 0A5 5 0 015 8a1 1 0 00-2 0 7.001 7.001 0 006 6.93V17H6a1 1 0 100 2h8a1 1 0 100-2h-3v-2.07z" clipRule="evenodd"></path>
                        </svg>
                    </button>
                </div>
                <button onClick={getMoviesByName} className="inline-flex items-center py-2.5 px-3 ml-2 text-sm font-medium text-white bg-blue-700 border border-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">
                    <svg aria-hidden="true" className="mr-2 -ml-1 w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"></path>
                    </svg>
                    Search
                </button>
            </div>

            <div className="flex flex-wrap justify-start -mx-2 mt-4">
                {movies.map((movie) => (
                    <div key={movie.id} className="w-full md:w-1/2 lg:w-1/3 px-2 mb-4">
                        <div className='bg-white rounded-lg shadow-xl overflow-hidden'>
                            <img
                                src={`https://image.tmdb.org/t/p/w500/${movie.poster_path}`}
                                className='h-60 md:h-72 w-full object-cover'
                                alt={movie.title}
                            />
                            <div className='p-3 md:p-4'>
                                <a
                                    href={movie.link}
                                    className='block text-cyan-700 font-bold text-lg md:text-xl mb-1 hover:text-cyan-600 line-clamp-2'
                                >
                                    {movie.title}
                                </a>
                                <p className='text-slate-400 mb-1 md:mb-2 text-sm'>{movie.release_date}</p>
                                <p className='text-sm md:text-base text-gray-600 line-clamp-3'>{movie.overview}</p>
                                <div className='flex justify-between mt-3 md:mt-4'>
                                    <div className='flex items-center'>
                                        <span className='text-yellow-300 text-base md:text-lg mr-1'>IMDB SCORE:</span>
                                        <span className='text-yellow-600 text-base md:text-lg font-bold'>{movie.vote_average}</span>
                                        <svg
                                            width='20px'
                                            height='20px'
                                            viewBox='0 0 24 24'
                                            fill='none'
                                            xmlns='http://www.w3.org/2000/svg'
                                            className='ml-1 text-yellow-600 h-4 w-4 md:h-5 md:w-5'
                                        >
                                            <path
                                                d='M9.15316 5.40838C10.4198 3.13613 11.0531 2 12 2C12.9469 2 13.5802 3.13612 14.8468 5.40837L15.1745 5.99623C15.5345 6.64193 15.7144 6.96479 15.9951 7.17781C16.2757 7.39083 16.6251 7.4699 17.3241 7.62805L17.9605 7.77203C20.4201 8.32856 21.65 8.60682 21.9426 9.54773C22.2352 10.4886 21.3968 11.4691 19.7199 13.4299L19.2861 13.9372C18.8096 14.4944 18.5713 14.773 18.4641 15.1177C18.357 15.4624 18.393 15.8341 18.465 16.5776L18.5306 17.2544C18.7841 19.8706 18.9109 21.1787 18.1449 21.7602C17.3788 22.3417 16.2273 21.8115 13.9243 20.7512L13.3285 20.4768C12.6741 20.1755 12.3469 20.0248 12 20.0248C11.6531 20.0248 11.3259 20.1755 10.6715 20.4768L10.0757 20.7512C7.77268 21.8115 6.62118 22.3417 5.85515 21.7602C5.08912 21.1787 5.21588 19.8706 5.4694 17.2544L5.53498 16.5776C5.60703 15.8341 5.64305 15.4624 5.53586 15.1177C5.42868 14.773 5.19043 14.4944 4.71392 13.9372L4.2801 13.4299C2.60325 11.4691 1.76482 10.4886 2.05742 9.54773C2.35002 8.60682 3.57986 8.32856 6.03954 7.77203L6.67589 7.62805C7.37485 7.4699 7.72433 7.39083 8.00494 7.17781C8.28555 6.96479 8.46553 6.64194 8.82547 5.99623L9.15316 5.40838Z'
                                                fill='#eab308'
                                            />
                                        </svg>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                ))}
            </div>

            {pages > 1 && (
                <div className="flex justify-center items-center mb-5">
                    <ul className="flex items-center -mx-1">
                        <li className="px-1">
                            <a
                                href="#"
                                className="w-9 h-9 flex items-center justify-center rounded-md border border-[#EDEFF1] text-[#838995] text-base hover:bg-primary hover:border-primary hover:text-white"
                                onClick={goToPreviousPage}
                                style={{ visibility: currentPage === 1 ? 'hidden' : 'visible' }}
                            >
                                <svg width="8" height="15" viewBox="0 0 8 15" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <path d="M7.12979 1.91389L7.1299 1.914L7.1344 1.90875C7.31476 1.69833 7.31528 1.36878 7.1047 1.15819C7.01062 1.06412 6.86296 1.00488 6.73613 1.00488C6.57736 1.00488 6.4537 1.07206 6.34569 1.18007L6.34564 1.18001L6.34229 1.18358L0.830207 7.06752C0.830152 7.06757 0.830098 7.06763 0.830043 7.06769C0.402311 7.52078 0.406126 8.26524 0.827473 8.73615L0.827439 8.73618L0.829982 8.73889L6.34248 14.6014L6.34243 14.6014L6.34569 14.6047C6.546 14.805 6.88221 14.8491 7.1047 14.6266C7.30447 14.4268 7.34883 14.0918 7.12833 13.8693L1.62078 8.01209C1.55579 7.93114 1.56859 7.82519 1.61408 7.7797L1.61413 7.77975L1.61729 7.77639L7.12979 1.91389Z" fill="#333333" />
                                </svg>
                            </a>
                        </li>
                        {[...Array(pages)].map((_, index) => (
                            <li key={index} className="px-1">
                                <a
                                    href="#"
                                    className={`w-9 h-9 flex items-center justify-center rounded-md border border-[#EDEFF1] text-[#838995] text-base hover:bg-primary hover:border-primary hover:text-white ${currentPage === index + 1 ? 'bg-black text-white' : ''}`}
                                    onClick={() => handlePageClick(index + 1)}
                                >
                                    {index + 1}
                                </a>
                            </li>
                        ))}
                        <li className="px-1">
                            <a
                                href="#"
                                className="w-9 h-9 flex items-center justify-center rounded-md border border-[#EDEFF1] text-[#838995] text-base hover:bg-primary hover:border-primary hover:text-white"
                                onClick={goToNextPage}
                                style={{ visibility: currentPage === pages ? 'hidden' : 'visible' }}
                            >
                                <svg width="8" height="15" viewBox="0 0 8 15" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <path d="M0.870212 13.0861L0.870097 13.086L0.865602 13.0912C0.685237 13.3017 0.684716 13.6312 0.895299 13.8418C0.989374 13.9359 1.13704 13.9951 1.26387 13.9951C1.42264 13.9951 1.5463 13.9279 1.65431 13.8199L1.65436 13.82L1.65771 13.8164L7.16979 7.93248C7.16985 7.93243 7.1699 7.93237 7.16996 7.93231C7.59769 7.47923 7.59387 6.73477 7.17253 6.26385L7.17256 6.26382L7.17002 6.26111L1.65752 0.398611L1.65757 0.398563L1.65431 0.395299C1.454 0.194997 1.11779 0.150934 0.895299 0.373424C0.695526 0.573197 0.651169 0.908167 0.871667 1.13067L6.37922 6.98791C6.4442 7.06886 6.43141 7.17481 6.38592 7.2203L6.38587 7.22025L6.38271 7.22361L0.870212 13.0861Z" fill="#333333" />
                                </svg>
                            </a>
                        </li>
                    </ul>
                </div>
            )}
        </div>
    );
}

export default Movies;