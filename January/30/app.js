const express = require('express');
const connectDB = require('./configurations/dbContext');
const appRoutes = require('./routes/bookRoutes');
const { swaggerUi, specs } = require('./middlewares/swagger');

const app = express();

app.use(express.json());

connectDB();

app.use('/api/book', appRoutes);

app.use('/swagger', swaggerUi.serve, swaggerUi.setup(specs));

app.listen(3000, () => {
  console.log(`Server start on port 3000`);
  console.log(`Swagger UI available at http://localhost:3000/swagger`);
  console.log(`API available at http://localhost:3000/api/book`);
});