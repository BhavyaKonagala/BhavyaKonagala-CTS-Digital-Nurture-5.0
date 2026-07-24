# JWT Authentication Notes

## What is JWT?

JWT (JSON Web Token) is a secure token used for authentication between client and server.

---

## JWT Structure

A JWT has three parts:

- Header
- Payload
- Signature

---

## Authentication

Authentication verifies the identity of the user.

Example:

- Username
- Password

---

## Authorization

Authorization determines what resources an authenticated user can access.

---

## Benefits of JWT

- Stateless Authentication
- Secure
- Lightweight
- Easy to use with APIs

---

## Workflow

1. User logs in.
2. Server validates credentials.
3. JWT Token is generated.
4. Client stores the token.
5. Client sends the token in the Authorization header.
6. Server validates the token.
7. Protected resources are accessed.

---

## Sample Credentials

Username

```
admin
```

Password

```
admin123
```

---

## Protected Endpoint

```
GET /api/Auth/secure
```

Requires Bearer Token.

---

## Conclusion

JWT Authentication is commonly used in Microservices to securely authenticate and authorize users without maintaining server-side sessions.