const Book = require('../models/bookModel');
const { plainToInstance } = require('class-transformer');
const { v4: uuidv4 } = require('uuid');

const createBook = async (userData) => {
    const { Name, Author, PublicationYear, Genre } = userData;

    const existingBook = await Book.findOne({ Name });
    if (existingBook) throw new Error('Book already existing');

    const newBook = new Book({ Id: uuidv4(), Name, Author, PublicationYear, Genre });
    await newBook.save();

    return {
        book: plainToInstance(newBook.toObject()),
    };
};

module.exports = { createBook };