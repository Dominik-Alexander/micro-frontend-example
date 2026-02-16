// remote - ./src/components/Button.tsx
import React from "react";
import { Button as PrimeButton } from 'primereact/button'

interface ButtonProps {
    text: string;
    onClick?: () => void;
}

const Button: React.FC<ButtonProps> = ({ text, onClick }) => {
    return (
        <PrimeButton severity="success" label={text}  
        className="px-4 py-2 bg-green-500 text-white rounded hover:bg-green-600 hover:cursor-pointer" onClick={onClick}>
        </PrimeButton>
    );
};

export default Button;