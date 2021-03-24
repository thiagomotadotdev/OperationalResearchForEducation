import './index.scss';
import Pages from './pages/Pages';
import { Switch, Route, Redirect, BrowserRouter } from "react-router-dom";

export default function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/">
          <Redirect to="/web" />
        </Route>
        <Route path="/web" component={Pages} />
      </Switch>
    </BrowserRouter>
  );
}