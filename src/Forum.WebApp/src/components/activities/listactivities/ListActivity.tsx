import React, { Fragment, useState, useEffect, useRef } from "react";
import styles from "./ListActivity.module.css";
import { IActivity } from "../../../models/IActivity";
import axios from "axios";
const ListActivity = (props: any) => {
  const isUpdated = props.updated;
  const activities = props.activities;
  console.log(activities);
  const getDeail = (event: any) => {
    props.GetDetail(activities.find((x: any) => x.id === event.target.value));
  };
  return (
    <Fragment>
      <div className={styles.list_activity}>
        {activities.map((item: any) => (
          <div className={styles.activity} key={item.id}>
            <h2 className={styles.col__1}>{item.title}</h2>
            <p className={styles.col__1}>{item.date}</p>
            <p className={styles.col__1}>{item.description}</p>
            <span className={`${styles.col__1} ${styles.category}`}>
              {item.category}
            </span>
            <button
              className={`${styles.col__3} ${styles.button}`}
              value={item.id}
              onClick={getDeail}
            >
              View
            </button>
          </div>
        ))}
      </div>
    </Fragment>
  );
};
export default ListActivity;
