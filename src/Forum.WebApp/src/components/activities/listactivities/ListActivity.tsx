import React, { Fragment, useState, useEffect, useRef } from "react";
import styles from "./ListActivity.module.css";
import { IActivity } from "../../../models/IActivity";
import DetailActivity from "../activitydetail/DetailActivity";
import axios from "axios";
const ListActivity = (props: any) => {
  const [activities, setActivities] = useState<IActivity[]>([]);
  const getDeail = (event: any) => {
    props.GetDetail(activities.find((x) => x.id === event.target.value));
  };
  useEffect(() => {
    axios.get("https://localhost:5001/api/Activities").then((response: any) => {
      setActivities(response.data.data);
    });
  }, []);
  return (
    <Fragment>
      <div className={styles.list_activity}>
        {activities.map((activities) => (
          <Fragment>
            <div className={styles.activity} key={activities.id}>
              <h2 className={styles.col__1}>{activities.title}</h2>
              <p className={styles.col__1}>{activities.date}</p>
              <p className={styles.col__1}>{activities.description}</p>
              <span className={`${styles.col__1} ${styles.category}`}>
                {activities.category}
              </span>
              <button
                className={`${styles.col__3} ${styles.button}`}
                value={activities.id}
                onClick={getDeail}
              >
                View
              </button>
            </div>
          </Fragment>
        ))}
      </div>
    </Fragment>
  );
};
export default ListActivity;
