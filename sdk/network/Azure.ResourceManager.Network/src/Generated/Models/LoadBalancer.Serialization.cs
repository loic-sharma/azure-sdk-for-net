// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FrontendIPConfigurations))
            {
                writer.WritePropertyName("frontendIPConfigurations");
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackendAddressPools))
            {
                writer.WritePropertyName("backendAddressPools");
                writer.WriteStartArray();
                foreach (var item in BackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancingRules))
            {
                writer.WritePropertyName("loadBalancingRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Probes))
            {
                writer.WritePropertyName("probes");
                writer.WriteStartArray();
                foreach (var item in Probes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InboundNatRules))
            {
                writer.WritePropertyName("inboundNatRules");
                writer.WriteStartArray();
                foreach (var item in InboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InboundNatPools))
            {
                writer.WritePropertyName("inboundNatPools");
                writer.WriteStartArray();
                foreach (var item in InboundNatPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OutboundRules))
            {
                writer.WritePropertyName("outboundRules");
                writer.WriteStartArray();
                foreach (var item in OutboundRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LoadBalancer DeserializeLoadBalancer(JsonElement element)
        {
            Optional<LoadBalancerSku> sku = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<FrontendIPConfiguration>> frontendIPConfigurations = default;
            Optional<IList<BackendAddressPool>> backendAddressPools = default;
            Optional<IList<LoadBalancingRule>> loadBalancingRules = default;
            Optional<IList<Probe>> probes = default;
            Optional<IList<InboundNatRule>> inboundNatRules = default;
            Optional<IList<InboundNatPool>> inboundNatPools = default;
            Optional<IList<OutboundRule>> outboundRules = default;
            Optional<string> resourceGuid = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = LoadBalancerSku.DeserializeLoadBalancerSku(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frontendIPConfigurations"))
                        {
                            List<FrontendIPConfiguration> array = new List<FrontendIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontendIPConfiguration.DeserializeFrontendIPConfiguration(item));
                            }
                            frontendIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPools"))
                        {
                            List<BackendAddressPool> array = new List<BackendAddressPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BackendAddressPool.DeserializeBackendAddressPool(item));
                            }
                            backendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"))
                        {
                            List<LoadBalancingRule> array = new List<LoadBalancingRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LoadBalancingRule.DeserializeLoadBalancingRule(item));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("probes"))
                        {
                            List<Probe> array = new List<Probe>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Probe.DeserializeProbe(item));
                            }
                            probes = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundNatRules"))
                        {
                            List<InboundNatRule> array = new List<InboundNatRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InboundNatRule.DeserializeInboundNatRule(item));
                            }
                            inboundNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundNatPools"))
                        {
                            List<InboundNatPool> array = new List<InboundNatPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InboundNatPool.DeserializeInboundNatPool(item));
                            }
                            inboundNatPools = array;
                            continue;
                        }
                        if (property0.NameEquals("outboundRules"))
                        {
                            List<OutboundRule> array = new List<OutboundRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(OutboundRule.DeserializeOutboundRule(item));
                            }
                            outboundRules = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LoadBalancer(id.Value, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), sku.Value, etag.Value, Optional.ToList(frontendIPConfigurations), Optional.ToList(backendAddressPools), Optional.ToList(loadBalancingRules), Optional.ToList(probes), Optional.ToList(inboundNatRules), Optional.ToList(inboundNatPools), Optional.ToList(outboundRules), resourceGuid.Value, Optional.ToNullable(provisioningState));
        }
    }
}
