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
        {/* <label for="question">What is your question:</label>
        <textarea id="story" name="story" rows="5" cols="33" /> */}
        <input type="submit" value="Submit" className="submit-btn" />

        <section className="top-questions">
          <h1>Top Questions</h1>
          <ul>
            <li>Blah blah</li>
            <li>Blah blah</li>
            <li>Blah blah</li>
            <li>Blah blah</li>
          </ul>
        </section>
      </div>
    )
  }
}
