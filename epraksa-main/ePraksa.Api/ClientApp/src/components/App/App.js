import React from "react";
import Home from "../Home/Home";
import Mentors from '../Mentors/Mentors'
import PrivateRoute from "../Router/PrivateRouter";
import { Route } from 'react-router';



const App = () => {
 
  return (
    <div>
    <Route exact path="/" component={Home} />

    <PrivateRoute path="/home" component={Home} />
    <PrivateRoute path="/mentors" component={Mentors} />
    
    </div>
   
  );
};
export default App;

