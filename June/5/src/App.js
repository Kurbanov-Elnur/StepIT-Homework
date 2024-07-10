import React from 'react';
import './App.css';
import MovieSchedule from './components/movie';
import BlogPosts from './components/blog';
import CityInfo from './components/city';

const movies = [
      {
          title: 'Avengers: Endgame',
          description: 'After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos\'s actions and restore balance to the universe.',
          poster: 'https://www.joblo.com/assets/images/oldsite/posters/images/full/avengers-endgame-poster-2.jpg',
          showtimes: ['10:00 AM', '1:00 PM', '4:00 PM', '7:00 PM']
      },
      {
          title: 'The Dark Knight',
          description: 'When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.',
          poster: 'https://images-na.ssl-images-amazon.com/images/I/81AJdOIEIhL._AC_SY679_.jpg',
          showtimes: ['11:00 AM', '2:00 PM', '5:00 PM', '8:00 PM']
      }
  ];

const posts = [
    {
        title: 'React Hooks Tutorial',
        content: 'In this tutorial, we will learn about React Hooks and how to use them effectively in your React applications.',
        date: '2023-06-21',
        tags: ['React', 'JavaScript', 'Frontend']
    },
    {
        title: 'CSS Grid Layout Basics',
        content: 'CSS Grid Layout is a powerful layout system available in CSS that allows you to design complex web layouts with ease.',
        date: '2023-06-20',
        tags: ['CSS', 'Web Design', 'Frontend']
    }
];

const cities = [
      {
          country: 'United States',
          name: 'New York City',
          description: 'New York City is the most populous city in the United States. With an estimated 2019 population of 8,336,817 distributed over about 302.6 square miles (784 km2), New York is also the most densely populated major city in the United States.',
          coatOfArms: 'https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Seal_of_New_York_City.svg/1024px-Seal_of_New_York_City.svg.png',
          population: '8,336,817',
          area: '784'
      },
      {
          country: 'United Kingdom',
          name: 'London',
          description: 'London is the capital and largest city of England and the United Kingdom. It stands on the River Thames in south-east England at the head of a 50-mile (80 km) estuary leading to the North Sea.',
          coatOfArms: 'https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Coat_of_arms_of_the_City_of_London.svg/1024px-Coat_of_arms_of_the_City_of_London.svg.png',
          population: '9,304,016',
          area: '1572'
      }
  ];

function App() {
  return (
    <div className="App">
      <BlogPosts posts={posts} />
    </div>
  );
}

export default App;