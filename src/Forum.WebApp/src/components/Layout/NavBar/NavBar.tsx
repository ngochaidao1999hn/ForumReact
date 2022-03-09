import React, { Fragment } from "react";
import styles from "./NavBar.module.css";
const NavBar = (props: any) => {
  const createActivityHandler = () => {
    props.createActivity(true);
  };
  return (
    <Fragment>
      <div className={styles.navbar}>
        <img src="assets/logo/logo.png" alt="logo"></img>
        <nav className={styles.pages}>
          <a>Activity</a>
          <a onClick={createActivityHandler}>Create Activity</a>
        </nav>
      </div>
    </Fragment>
  );
};
export default NavBar;
