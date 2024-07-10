import React from 'react';

export default function MovieSchedule ({ movies }) {
    return (
        <div className="bg-gray-100 p-6">
            <div className="max-w-4xl mx-auto">
                <div className="grid gap-6 md:grid-cols-2">
                    {movies.map((movie, index) => (
                        <div key={index} className="bg-white shadow-md rounded-lg p-4">
                            <h2 className="text-xl font-bold mb-2">{movie.title}</h2>
                            <p className="text-gray-700 mb-4">{movie.description}</p>
                            <img src={movie.poster} alt={`${movie.title} poster`} className="mb-4" style={{ maxWidth: '200px' }} />
                            <h3 className="text-lg font-semibold mb-2">Showtimes:</h3>
                            <ul className="list-disc pl-4">
                                {movie.showtimes.map((time, idx) => (
                                    <li key={idx} className="text-gray-700">{time}</li>
                                ))}
                            </ul>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
};