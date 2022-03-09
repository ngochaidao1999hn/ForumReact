import React, { Fragment, useEffect, useState } from "react";
import DetailActivity from "./activitydetail/DetailActivity";
import ListActivity from "./listactivities/ListActivity";
import styles from "./activity.module.css";
import ActivityForm from "./form/ActivityForm";
import { IActivity } from "../../models/IActivity";
import axios from "axios";
const Activity = (props: any) => {
  const [activity, setActivity] = useState("");
  const [activities, setActivities] = useState<IActivity[]>([]);
  const [open, setOpen] = useState(false);
  const isOpen = props.openForm;
  useEffect(() => {
    axios.get("https://localhost:5001/api/Activities").then((response: any) => {
      setActivities(response.data.data);
    });
  }, []);
  useEffect(() => {
    setOpen(isOpen);
  }, [isOpen]);
  const getDetailHandler = (activity: any) => {
    setActivity(activity);
    window.scrollTo(0, 0);
  };
  const closeFormHandler = (close: boolean) => {
    if (close) {
      setOpen(true);
    } else {
      setActivity("");
      setOpen(false);
      props.closeForm(false);
    }
  };
  const updatedHandler = (data: IActivity) => {
    if (data.id !== undefined) {
      let index = activities.findIndex((x) => x.id == data.id);
      let newArr = [...activities];
      newArr[index] = data;
      setActivities(newArr);
    } else {
      setActivities([...activities, data]);
    }
  };
  return (
    <Fragment>
      <section className={styles.activity}>
        <div className={styles.left}>
          <ListActivity GetDetail={getDetailHandler} activities={activities} />
        </div>
        <div className={styles.right}>
          {activity && (
            <DetailActivity activity={activity} closeForm={closeFormHandler} />
          )}
          {open && (
            <ActivityForm
              model={activity}
              closeForm={closeFormHandler}
              updatedData={updatedHandler}
            />
          )}
        </div>
      </section>
    </Fragment>
  );
};
export default Activity;
