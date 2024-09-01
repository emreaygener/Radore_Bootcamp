const initState = {
  posts: [
    { id: "1", title: "Blog1", body: "Blog1 İçerik" },
    { id: "2", title: "Blog2", body: "Blog2 İçerik" },
    { id: "3", title: "Blog3", body: "Blog3 İçerik" },
    { id: "4", title: "Blog4", body: "Blog4 İçerik" },
    { id: "5", title: "Blog5", body: "Blog5 İçerik" },
  ],
};

const rootReducer = (state = initState, action) => {
  if (action.type === "DELETE_POST") {
    console.log("delete işleminden önceki liste", state.posts);
    let yeniPostlar = state.posts.filter((post) => {
      return action.id !== post.id;
    });
    console.log("kalan liste: ", yeniPostlar);
    return {
      ...state,
      posts: yeniPostlar,
    };
  }
  return state;
};

export default rootReducer;
