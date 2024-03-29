import { useState } from "react";
import reactLogo from "./assets/react.svg";
import "./App.css";
import Home from "./components/Home/Home";

function App() {
    const [count, setCount] = useState(0);

    return (
        <div>
            <h1 className="text-3xl font-bold underline">Hello world!</h1>
            <div className="card">
                <Home />
                <button onClick={() => setCount((count) => count + 1)}>
                    count is {count}
                </button>
            </div>
        </div>
    );
}

export default App;
