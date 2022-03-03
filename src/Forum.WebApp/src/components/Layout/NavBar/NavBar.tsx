import React, { Fragment } from "react";
import styles from "./NavBar.module.css";
const NavBar = (props: any) => {
  return (
    <Fragment>
      <div className={styles.navbar}>
        <img src="assets/logo/logo.png" alt="logo"></img>
        <nav className={styles.pages}>
          <a>Activity</a>
          <a>Create Activity</a>
        </nav>
      </div>
    </Fragment>
  );
};
export default NavBar;
