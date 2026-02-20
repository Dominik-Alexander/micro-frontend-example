import { useState } from 'react'
import { Button } from 'primereact/button'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <h1 className='text-3xl font-bold text-amber-500'>Vite + React</h1>
      <div className="card">
        <Button severity="success" label='Click me!' onClick={() => setCount((count) => count + 1)}>
        </Button>
        <p>
          count is {count}
        </p>
        <button className='px-4 py-2 bg-green-500 text-white rounded hover:bg-green-600 cursor-pointer'>
          Tailwind Button
        </button>
      </div>
    </>
  )
}

export default App
