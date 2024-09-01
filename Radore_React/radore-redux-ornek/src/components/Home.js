import React, { Component } from "react";
import { connect } from "react-redux";
import { deletePost } from "../actions/deleteAction";
import "bootstrap/dist/css/bootstrap.min.css";

class Home extends Component {
  deleteClicked = (e) => {
    console.log(e.target.id);
    this.props.deletePost(e.target.id);
  };

  render() {
    const { gelenPostlar } = this.props;
    const postListesi = gelenPostlar.length ? (
      gelenPostlar.map((post) => {
        return (
          <div className="post card" key={post.id}>
            <div className="card-content">
              <span className="card-title red-text">{post.title}</span>
              <p>{post.body}</p>
            </div>
            <button
              onClick={this.deleteClicked}
              className="btn btn-danger"
              id={post.id}
            >
              Sil
            </button>{" "}
          </div>
        );
      })
    ) : (
      <div className="center">Post yok</div>
    );
    return (
      <>
        <div className="container">
          <h4 className="center">Home</h4>
          {postListesi}
        </div>
      </>
    );
  }
}

// State in içindeki verileri home componentine taşımamızı sağlar.
const mapStateToProps = (state) => {
  return {
    gelenPostlar: state.posts,
  };
  // state içindeki postları gelenPostlar ismiyle home componentine taşıdık.
};

const mapDispatchToProps = (dispatch) => {
  return {
    deletePost: (id) => dispatch(deletePost(id)),
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Home);
