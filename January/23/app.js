const express = require("express");
const connectDB = require('./configurations/dbContext');
const appRoutes = require('./routes/bookRoutes');

const app = express();

app.use(express.json());

connectDB();

app.use("/api/book", appRoutes);

app.listen(3000, () => {
  console.log(`🚀 Сервер запущен на порту ${3000}`);
  console.log(`http://localhost:${3000}`);
});