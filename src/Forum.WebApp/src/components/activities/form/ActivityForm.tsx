import axios from "axios";
import React, { ChangeEvent, Fragment, useEffect, useState } from "react";
import styles from "./ActivityForm.module.css";
const ActivityForm = (props: any) => {
  const model =
    props.model === null
      ? {
          id: "",
          title: "",
          category: "",
          description: "",
          date: "",
          city: "",
          venue: "",
        }
      : {
          id: props.model.id,
          title: props.model.title,
          category: props.model.category,
          description: props.model.description,
          date: props.model.date,
          city: props.model.city,
          venue: props.model.venue,
        };

  const [updatedActivity, setUpdatedActivity] = useState(model);
  const cancelhandler = () => {
    props.closeForm(false);
  };
  const InputHandle = (
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = event.target;
    setUpdatedActivity({ ...updatedActivity, [name]: value });
  };
  const submitHandler = (event: any) => {
    updatedActivity.id
      ? axios.put("https://localhost:5001/api/Activities", updatedActivity)
      : axios.post("https://localhost:5001/api/Activities", updatedActivity);
    console.log(updatedActivity);
    props.updatedData(updatedActivity);
    props.closeForm(false);
  };
  return (
    <Fragment>
      <div className={styles.create_form}>
        <form autoComplete="off" onSubmit={submitHandler}>
          <input type="hidden" name="id" defaultValue={model.id} />
          <input
            type="text"
            placeholder="title"
            name="title"
            defaultValue={model.title}
            onChange={InputHandle}
          />
          <br />
          <textarea
            placeholder="Description"
            name="description"
            defaultValue={model.description}
            onChange={InputHandle}
          />
          <br />
          <input
            type="text"
            name="category"
            placeholder="Category"
            defaultValue={model.category}
            onChange={InputHandle}
          />
          <br />
          <input
            type="date"
            placeholder="Date"
            name="date"
            defaultValue={model.date}
            onChange={InputHandle}
          />
          <br />
          <input
            type="text"
            placeholder="City"
            name="city"
            defaultValue={model.city}
            onChange={InputHandle}
          />
          <br />
          <input
            type="text"
            placeholder="Venue"
            name="venue"
            defaultValue={model.venue}
            onChange={InputHandle}
          />
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
