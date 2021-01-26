import React from "react";
import Header from "../Header/Header";
import Login from "../Login/Login";
import Students from "../Students/Students"
import styles from "./Home.module.css";
import { useSelector } from "react-redux";

const Home = (props) => {
  const { student } = useSelector((state) => state);
  const isAuth = student.isAuthenticated;
  return (
    <div className={styles.main}>
      <div><Header/></div>
      <div>e-Praksa</div>
      <div>
      {isAuth ?  <Students/> : <Login/> }
      </div>
    </div>
  );
};

export default Home;
