# Smart Home Device Management System

A C#/.NET console project demonstrating object-oriented modelling for smart-home devices.

## Overview

This project models several smart-device types through a shared base class, specialised subclasses, and interfaces. It focuses on core object-oriented design rather than data persistence.

## What the Public Repository Demonstrates

- C# and .NET console development
- Inheritance
- Encapsulation
- Polymorphism
- Interface implementation
- Device-specific behaviour
- Reusable manufacturer/device relationships

## Domain Model

### Base Class

`SmartDevice`

Represents shared device information and behaviour such as identity, manufacturer details, and power state.

### Device Types

- `SmartLight`
- `SmartThermostat`
- `SmartDoorLock`

### Interfaces

- `IBatteryPowered`
- `ISmartDoorLock`

Interfaces are used to model capabilities that do not belong to every device type.

## Example Responsibilities

- Toggle device power state
- Adjust light brightness
- Set thermostat temperature
- Lock/unlock a smart door lock
- Track and recharge battery-powered devices
- Return formatted device status information

## Tech Stack

- C#
- .NET
- Object-Oriented Programming
- Visual Studio

## Learning Focus

The project demonstrates practical understanding of:

- Designing a reusable class hierarchy
- Overriding behaviour in derived classes
- Protecting state through controlled property setters
- Using interfaces for capability-based design
- Keeping device-specific responsibilities inside the correct classes

## Important Repository Note

This repository represents the **OOP smart-home project currently available publicly**. It does **not** currently contain the later EF Core/SQLite persistence layer discussed in other coursework. Those capabilities should only be advertised publicly once the completed assignment version has been pushed to GitHub.

## Author

**Lerato Molefe**

- Portfolio: https://leratogladys.github.io/Portfolio
- GitHub: https://github.com/Leratogladys
