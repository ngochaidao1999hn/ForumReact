import React, { Fragment, useState } from "react";
import DetailActivity from "./activitydetail/DetailActivity";
import ListActivity from "./listactivities/ListActivity";
import styles from "./activity.module.css";
import ActivityForm from "./form/ActivityForm";
const Activity = () => {
  const [activity, setActivity] = useState("");
  const [editMode, setEditMode] = useState(false);
  const getDetailHandler = (activity: any) => {
    setActivity(activity);
  };
  const closeHandle = (close: boolean) => {
    if (close) {
      setActivity("");
      setEditMode(false);
    }
  };
  const editHandler = (edit: boolean) => {
    if (edit) {
      setEditMode(true);
    } else {
      setEditMode(false);
    }
  };

  return (
    <Fragment>
      <section className={styles.activity}>
        <div className={styles.left}>
          <ListActivity GetDetail={getDetailHandler} />
        </div>
        <div className={styles.right}>
          {activity && (
            <DetailActivity
              activity={activity}
              close={closeHandle}
              edit={editHandler}
            />
          )}
          {editMode && activity && (
            <ActivityForm model={activity} edit={editHandler} />
          )}
        </div>
      </section>
    </Fragment>
  );
};
export default Activity;
