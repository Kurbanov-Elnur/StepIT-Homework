import React from 'react';

const CityInfo = ({ cities }) => {
    return (
        <div className="city-info">
            {cities.map((city, index) => (
                <div key={index} className="city">
                    <h2>{city.country}</h2>
                    <h3>{city.name}</h3>
                    <p>{city.description}</p>
                    <img src={city.coatOfArms} alt={`${city.name} coat of arms`} width="100" />
                    <p><strong>Population:</strong> {city.population}</p>
                    <p><strong>Area:</strong> {city.area} km²</p>
                </div>
            ))}
        </div>
    );
};

export default CityInfo;