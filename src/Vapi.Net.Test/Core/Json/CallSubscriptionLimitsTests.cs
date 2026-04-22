using NUnit.Framework;
using Vapi.Net.Core;

namespace Vapi.Net.Test.Core.Json;

[TestFixture]
public class CallSubscriptionLimitsTests
{
    [Test]
    public void Call_WithSubscriptionLimits_ShouldDeserializeCorrectly()
    {
        // Arrange - simulates the JSON returned by the CreateCall REST API
        const string json = """
            {
                "id": "call-123",
                "orgId": "org-456",
                "createdAt": "2025-01-01T00:00:00Z",
                "updatedAt": "2025-01-01T00:00:00Z",
                "subscriptionLimits": {
                    "concurrencyBlocked": false,
                    "concurrencyLimit": 500,
                    "remainingConcurrentCalls": 499
                }
            }
            """;

        // Act
        var call = JsonUtils.Deserialize<Call>(json);

        // Assert
        Assert.That(call, Is.Not.Null);
        Assert.That(call.SubscriptionLimits, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(call.SubscriptionLimits!.ConcurrencyBlocked, Is.False);
            Assert.That(call.SubscriptionLimits!.ConcurrencyLimit, Is.EqualTo(500));
            Assert.That(call.SubscriptionLimits!.RemainingConcurrentCalls, Is.EqualTo(499));
        });
    }

    [Test]
    public void Call_WithoutSubscriptionLimits_ShouldDeserializeWithNull()
    {
        // Arrange - simulates a response that doesn't include subscriptionLimits
        const string json = """
            {
                "id": "call-123",
                "orgId": "org-456",
                "createdAt": "2025-01-01T00:00:00Z",
                "updatedAt": "2025-01-01T00:00:00Z"
            }
            """;

        // Act
        var call = JsonUtils.Deserialize<Call>(json);

        // Assert
        Assert.That(call, Is.Not.Null);
        Assert.That(call.SubscriptionLimits, Is.Null);
    }

    [Test]
    public void Call_WithSubscriptionLimits_ShouldSerializeCorrectly()
    {
        // Arrange
        var call = new Call
        {
            Id = "call-123",
            OrgId = "org-456",
            CreatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            UpdatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            SubscriptionLimits = new SubscriptionLimits
            {
                ConcurrencyBlocked = false,
                ConcurrencyLimit = 500,
                RemainingConcurrentCalls = 499,
            },
        };

        // Act
        var json = JsonUtils.Serialize(call);
        var deserialized = JsonUtils.Deserialize<Call>(json);

        // Assert
        Assert.That(deserialized, Is.Not.Null);
        Assert.That(deserialized.SubscriptionLimits, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(deserialized.SubscriptionLimits!.ConcurrencyBlocked, Is.False);
            Assert.That(deserialized.SubscriptionLimits!.ConcurrencyLimit, Is.EqualTo(500));
            Assert.That(
                deserialized.SubscriptionLimits!.RemainingConcurrentCalls,
                Is.EqualTo(499)
            );
        });
    }

    [Test]
    public void Call_WithConcurrencyBlocked_ShouldDeserializeCorrectly()
    {
        // Arrange - simulates a blocked call response
        const string json = """
            {
                "id": "call-789",
                "orgId": "org-456",
                "createdAt": "2025-01-01T00:00:00Z",
                "updatedAt": "2025-01-01T00:00:00Z",
                "subscriptionLimits": {
                    "concurrencyBlocked": true,
                    "concurrencyLimit": 10,
                    "remainingConcurrentCalls": 0
                }
            }
            """;

        // Act
        var call = JsonUtils.Deserialize<Call>(json);

        // Assert
        Assert.That(call, Is.Not.Null);
        Assert.That(call.SubscriptionLimits, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(call.SubscriptionLimits!.ConcurrencyBlocked, Is.True);
            Assert.That(call.SubscriptionLimits!.ConcurrencyLimit, Is.EqualTo(10));
            Assert.That(call.SubscriptionLimits!.RemainingConcurrentCalls, Is.EqualTo(0));
        });
    }
}
