import { UserController } from './controllers/userController.js';

let uc = new UserController();
uc.getUsers("https://jsonplaceholder.typicode.com/users");