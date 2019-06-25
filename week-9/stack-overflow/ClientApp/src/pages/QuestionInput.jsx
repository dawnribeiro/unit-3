import React, { Component } from 'react'

export class QuestionInput extends Component {
  render() {
    return (
      <div>
        <input type="text" placeholder="Ask a question" />
        <input type="submit" value="Submit" />
      </div>
    )
  }
}
