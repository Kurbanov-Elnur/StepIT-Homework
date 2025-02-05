const Book = require('../models/bookModel');
const { plainToInstance } = require('class-transformer');
const { v4: uuidv4 } = require('uuid');

const createBook = async (bookData) => {
    const { Name, Author, PublicationYear, Genre } = bookData;

    const existingBook = await Book.findOne({ Name });
    if (existingBook) throw new Error('Book already exists');

    const newBook = new Book({ Id: uuidv4(), Name, Author, PublicationYear, Genre });
    await newBook.save();

    return {
        book: newBook.toObject(),
    };
};

const getBookByName = async (name) => {
    const book = await Book.findOne({ Name: name });
    if (!book) throw new Error('Book not found');

    return {
        book: book.toObject(),
    };
};

const getBooks = async () => {
    const books = await Book.find();
    return {
        books: books.map((book) => book.toObject()),
    };
};

const updateBookByName = async (name, bookData) => {
    const { Author, PublicationYear, Genre } = bookData;

    const book = await Book.findOne({ Name: name });
    if (!book) throw new Error('Book not found');

    book.Author = Author || book.Author;
    book.PublicationYear = PublicationYear || book.PublicationYear;
    book.Genre = Genre || book.Genre;

    await book.save();

    return {
        book: book.toObject(),
    };
};

const deleteBookByName = async (name) => {
    const book = await Book.findOne({ Name: name });
    if (!book) throw new Error('Book not found');

    await book.remove();

    return { message: 'Book deleted successfully' };
};

module.exports = {
    createBook,
    getBookByName,
    getBooks,
    updateBookByName,
    deleteBookByName,
};