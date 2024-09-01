import React, { Component } from "react";

class YasamDongusu extends Component {
  constructor(props) {
    super(props);
    this.state = {
      date: new Date(),
      sure: 10,
    };
  }
  componentDidMount() {
    this.timerID = setInterval(() => this.tick(), 1000);
  }
  tick() {
    if (this.state.sure === 0) {
      this.componentWillUnmount();
      return;
    }
    this.setState({
      date: new Date(),
      sure: this.state.sure - 1,
    });
  }
  componentWillUnmount() {
    clearInterval(this.timerID);
  }
  componentDidUpdate() {
    console.log(this.state.süre, "değişiyor");
  }
  render() {
    return (
      <div>
        <h1>Yaşam Döngüsü</h1>
        <h2>{this.state.date.toLocaleTimeString()}</h2>
        <h3>Geri sayım: {this.state.sure}</h3>
      </div>
    );
  }
}

export default YasamDongusu;
