import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div>
        <h1>Hello, *Username*!</h1>
            <p>Welcome to your personal Knot app</p>
            <table>
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Date</th>
                        <th>Actions</th>
                    </tr>
                </thead>
            </table>
      </div>
    );
  }
}
