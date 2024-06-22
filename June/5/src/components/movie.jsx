import React from 'react';

const MovieSchedule = ({ movies }) => {
    return (
        <div className="movie-schedule">
            {movies.map((movie, index) => (
                <div key={index} className="movie">
                    <h2>{movie.title}</h2>
                    <p>{movie.description}</p>
                    <img src={movie.poster} alt={`${movie.title} poster`} width="200" />
                    <h3>Showtimes:</h3>
                    <ul>
                        {movie.showtimes.map((time, idx) => (
                            <li key={idx}>{time}</li>
                        ))}
                    </ul>
                </div>
            ))}
        </div>
    );
};

export default MovieSchedule;