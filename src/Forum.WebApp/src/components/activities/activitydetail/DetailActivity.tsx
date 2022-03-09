import React, { useState } from "react";
import styles from "./DetailActivity.module.css";
const DetailActivity = (props: any) => {
  const activity = props.activity;
  const closehandle = () => {
    props.closeForm(false);
  };
  const editHandler = () => {
    props.closeForm(true);
  };
  return (
    <div className={styles.detail}>
      <div className={styles.images}>
        <img src="assets/images/sport.jpg" alt="Cate"></img>
      </div>
      <div className={styles.content}>
        <h2>{activity.title}</h2>
        <p className={styles.date}>{activity.date}</p>
        <p>{activity.description}</p>
      </div>
      <div className={styles.buttons}>
        <button onClick={editHandler}>Edit</button>
        <button onClick={closehandle}>Cancel</button>
      </div>
    </div>
  );
};
export default DetailActivity;
