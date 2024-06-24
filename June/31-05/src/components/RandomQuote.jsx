import React, { useState, useEffect } from 'react';

const quotes = [
  "The greatest glory in living lies not in never falling, but in rising every time we fall. - Nelson Mandela",
  "The way to get started is to quit talking and begin doing. - Walt Disney",
  "Your time is limited, so don't waste it living someone else's life. - Steve Jobs",
  "If life were predictable it would cease to be life, and be without flavor. - Eleanor Roosevelt",
  "If you look at what you have in life, you'll always have more. - Oprah Winfrey",
  "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success. - James Cameron",
  "Life is what happens when you're busy making other plans. - John Lennon"
];

const RandomQuote = () => {
  const [quote, setQuote] = useState("");

  const getRandomQuote = () => {
    const randomIndex = Math.floor(Math.random() * quotes.length);
    setQuote(quotes[randomIndex]);
  };

  useEffect(() => {
    getRandomQuote();
    const interval = setInterval(getRandomQuote, 10000);
    return () => clearInterval(interval);
  }, []);

  return (
    <div className="flex flex-col items-center justify-center h-screen bg-gray-100 p-4">
      <div className="bg-white p-6 rounded-lg shadow-lg text-center">
        <p className="text-lg font-semibold mb-4">{quote}</p>
        <button
          onClick={getRandomQuote}
          className="bg-blue-500 text-white py-2 px-4 rounded hover:bg-blue-700 transition duration-300"
        >
          New Quote
        </button>
      </div>
    </div>
  );
};

export default RandomQuote;