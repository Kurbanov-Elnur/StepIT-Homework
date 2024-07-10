import React from 'react';

export default function CityInfo ({ cities }) {
    return (
        <div className="bg-gray-100 p-6">
            <div className="max-w-4xl mx-auto">
                <div className="grid gap-6 md:grid-cols-2">
                    {cities.map((city, index) => (
                        <div key={index} className="bg-white shadow-md rounded-lg p-4">
                            <h2 className="text-xl font-bold mb-2">{city.country}</h2>
                            <h3 className="text-lg font-semibold mb-2">{city.name}</h3>
                            <p className="text-gray-700 mb-4">{city.description}</p>
                            <img src={city.coatOfArms} alt={`${city.name} coat of arms`} className="mb-4" style={{ maxWidth: '100px' }} />
                            <p className="text-gray-600"><strong>Population:</strong> {city.population}</p>
                            <p className="text-gray-600"><strong>Area:</strong> {city.area} km²</p>
                        </div>
                    ))}
                </div>
            </div>
        </div>
    );
};