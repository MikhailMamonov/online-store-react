import axios from "axios";

const handleError = function(error) {
  if (error.response) {
    // Request made and server responded
    console.log(error.response.data);
    console.log(error.response.status);
    console.log(error.response.headers);
  } else if (error.request) {
    // The request was made but no response was received
    console.log(error.request);
  } else {
    // Something happened in setting up the request that triggered an Error
    console.log("Error", error.message);
  }
};

export const actions = {
  async USERS(context) {
    debugger;
    axios
      .get("users")
      .then((res) => context.commit("SET_USERS", res.data))
      .catch((err) => {
        handleError(err);
      });
  },
  async ADD_USER(context, data) {
    axios
      .post("users", data, {})
      .then((res) => {
        context.commit("ADD_USER", res.data);
      })
      .catch((err) => handleError(err));
  },
  async EDIT_USER(context, { item, id }) {
    axios
      .put(`users/${id}`, item, {})
      .then((res) => {
        debugger;
        context.commit("EDIT_USER", { user: res.data, id: id });
      })
      .catch((err) => handleError(err));
  },

  async DELETE_USER(context, id) {
    axios
      .delete(`users/${id}`)
      .then((res) => context.commit("DELETE_USER", res.data))
      .catch((error) => handleError(error));
  },
};
