import React, { Fragment } from "react";
import styles from "./ActivityForm.module.css";
const ActivityForm = (props: any) => {
  const model = props.model;
  const cancelhandler = () => {
    props.edit(false);
  };
  return (
    <Fragment>
      <div className={styles.create_form}>
        <form>
          <input type="text" placeholder="Title" value={model.title} />
          <br />
          <textarea placeholder="Description" value={model.description} />
          <br />
          <input type="text" placeholder="Category" value={model.category} />
          <br />
          <input type="date" placeholder="Date" value={model.date} />
          <br />
          <input type="text" placeholder="City" value={model.city} />
          <br />
          <input type="text" placeholder="Venue" value={model.venue} />
          <br />
          <div className={styles.buttons}>
            <button className={styles.button__cancel} onClick={cancelhandler}>
              Cancel
            </button>
            <button className={styles.button__submit} type="submit">
              Submit
            </button>
          </div>
        </form>
      </div>
    </Fragment>
  );
};
export default ActivityForm;
