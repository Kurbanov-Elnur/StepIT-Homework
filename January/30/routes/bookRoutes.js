const express = require('express');
const {
    createBook,
    getBookByName,
    getBooks,
    updateBook,
    deleteBook
} = require('../controllers/bookController');

const router = express.Router();

/**
 * @swagger
 * /api/book/create:
 *   post:
 *     summary: Create a new book
 *     description: Creates a book with the given parameters.
 *     requestBody:
 *       required: true
 *       content:
 *         application/json:
 *           schema:
 *             type: object
 *             properties:
 *               title:
 *                 type: string
 *               author:
 *                 type: string
 *               genre:
 *                 type: string
 *               publishedYear:
 *                 type: integer
 *     responses:
 *       201:
 *         description: Book successfully created
 *       400:
 *         description: Error creating the book
 */
router.post("/create", createBook);

/**
 * @swagger
 * /api/book/{name}:
 *   get:
 *     summary: Get a book by name
 *     description: Returns the book with the given name.
 *     parameters:
 *       - in: path
 *         name: name
 *         required: true
 *         schema:
 *           type: string
 *     responses:
 *       200:
 *         description: Book found
 *       404:
 *         description: Book not found
 */
router.get("/:name", getBookByName);

/**
 * @swagger
 * /api/book:
 *   get:
 *     summary: Get a list of all books
 *     description: Returns all books in the database.
 *     responses:
 *       200:
 *         description: List of books
 *       400:
 *         description: Error fetching books
 */
router.get("/", getBooks);

/**
 * @swagger
 * /api/book/{name}:
 *   put:
 *     summary: Update a book by name
 *     description: Updates information for the book with the given name.
 *     parameters:
 *       - in: path
 *         name: name
 *         required: true
 *         schema:
 *           type: string
 *     requestBody:
 *       required: true
 *       content:
 *         application/json:
 *           schema:
 *             type: object
 *             properties:
 *               title:
 *                 type: string
 *               author:
 *                 type: string
 *               genre:
 *                 type: string
 *               publishedYear:
 *                 type: integer
 *     responses:
 *       200:
 *         description: Book successfully updated
 *       404:
 *         description: Book not found
 */
router.put("/:name", updateBook);

/**
 * @swagger
 * /api/book/{name}:
 *   delete:
 *     summary: Delete a book by name
 *     description: Deletes the book with the given name.
 *     parameters:
 *       - in: path
 *         name: name
 *         required: true
 *         schema:
 *           type: string
 *     responses:
 *       200:
 *         description: Book successfully deleted
 *       404:
 *         description: Book not found
 */
router.delete("/:name", deleteBook);

module.exports = router;