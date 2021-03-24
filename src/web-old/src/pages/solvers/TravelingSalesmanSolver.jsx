import { useState } from "react";
import Form from "react-bootstrap/Form";
import Button from "react-bootstrap/Button";
import Container from "react-bootstrap/Container";
import Card from "react-bootstrap/Card";

export default function TravelingSalesmanSolver() {
  const [distanceMatrix, setDistanceMatrix] = useState();

  const [parameters, setParameters] = useState();

  const handle = {
    change: {
      parameters: (e) => {
        setParameters({
          ...parameters,
          [e.target.name]: e.target.value,
        });
      },

      distanceMatrix: (e) => {
        setDistanceMatrix({
          ...distanceMatrix,
          [e.target.name]: e.target.value,
        });
      },
    },

    execute: () => {
      console.log(parameters);
      console.log(distanceMatrix);

      let travelingSalesmanProblem = {
        numberOfPoints: parseInt(parameters.numberOfPoints, 10),
        startPoint: parseInt(parameters.startPoint, 10),
        distanceMatrix: []
      };
    },
  };

  const renderVars = (size) => {
    const renderVarsLine = (index, size) => {
      let line = [];
      for (let i = 0; i < size; i++) {
        line.push(
          <Form.Control
            name={`x_${index}_${i}`}
            type="number"
            placeholder={`x(${index + 1},${i + 1})`}
            style={{ maxWidth: "10%" }}
            onChange={handle.change.distanceMatrix}
          />
        );
      }
      return (
        <div
          style={{
            display: "flex",
            flexDirection: "row",
            flexWrap: "nowrap",
            justifyContent: "center",
            width: "100%",
          }}
        >
          {line}
        </div>
      );
    };

    let lines = [];
    for (let i = 0; i < size; i++) {
      lines.push(renderVarsLine(i, size));
    }
    return (
      <div
        style={{
          display: "flex",
          flexDirection: "column",
          flexWrap: "nowrap",
          justifyContent: "center",
          width: "100%",
        }}
      >
        {lines}
      </div>
    );
  };

  return (
    <Container>
      <Card style={{ marginTop: "50px" }}>
        <Card.Header>
          <Card.Title>Parameters</Card.Title>
        </Card.Header>
        <Card.Body>
          <Container>
            <Form>
              <Form.Group>
                <Form.Label>Number of points</Form.Label>
                <Form.Control
                  type="number"
                  name="numberOfPoints"
                  onChange={handle.change.parameters}
                />
              </Form.Group>
              <Form.Group>
                <Form.Label>Number of points</Form.Label>
                <Form.Control
                  type="number"
                  name="startPoint"
                  onChange={handle.change.parameters}
                />
              </Form.Group>
            </Form>
          </Container>
        </Card.Body>
      </Card>
      <Card style={{ marginTop: "50px" }}>
        <Card.Header>
          <Card.Title>Distance Matrix</Card.Title>
        </Card.Header>
        <Card.Body>
          <Form
            style={{ display: "flex", justifyContent: "center", width: "100%" }}
          >
            {renderVars(2)}
          </Form>
        </Card.Body>
      </Card>
      <Card style={{ marginTop: "50px" }}>
        <Card.Body>
          <Button style={{ width: "100%" }} onClick={handle.execute}>
            Execute
          </Button>
        </Card.Body>
      </Card>
    </Container>
  );
}
