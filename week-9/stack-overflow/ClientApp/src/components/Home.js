import React, { Component } from 'react'

export class Home extends Component {
  render() {
    return (
      <div>
        <input
          type="text"
          placeholder="Ask a question"
          className="question-input"
        />
        <input type="submit" value="Submit" />
      </div>
    )
  }
}
