import React, { Fragment, useState, useEffect } from "react";
import styles from "./ListActivity.module.css";
import { IActivity } from "../../models/IActivity";
import axios from "axios";
const ListActivity = (props: any) => {
  const [activities, setActivities] = useState<IActivity[]>([]);
  useEffect(() => {
    axios.get("https://localhost:5001/api/Activities").then((response: any) => {
      setActivities(response.data.data);
    });
  }, []);
  return (
    <Fragment>
      <div className={styles.list_activity}>
        {activities.map((activities) => (
          <div className={styles.activity} key={activities.id}>
            <p>{activities.title}</p>
          </div>
        ))}
      </div>
    </Fragment>
  );
};
export default ListActivity;
