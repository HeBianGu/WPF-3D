using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericVertexAttributeMapping
	/// </summary>
	/// <remarks>
	///    stores mapping for data arrays to
	/// generic vertex attributes.
	///
	/// vtkGenericVertexAttributeMapping stores mapping between data arrays and
	/// generic vertex attributes. It is used by vtkPainterPolyDataMapper to pass the
	/// mappings to the painter which rendering the attributes.
	/// @par Thanks:
	/// Support for generic vertex attributes in VTK was contributed in
	/// collaboration with Stephane Ploix at EDF.
	/// </remarks>
	// Token: 0x020007E1 RID: 2017
	public class vtkGenericVertexAttributeMapping : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014B62 RID: 84834 RVA: 0x001D50EF File Offset: 0x001D32EF
		static vtkGenericVertexAttributeMapping()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericVertexAttributeMapping.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericVertexAttributeMapping"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014B63 RID: 84835 RVA: 0x001D5117 File Offset: 0x001D3317
		public vtkGenericVertexAttributeMapping(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014B64 RID: 84836
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B65 RID: 84837 RVA: 0x001D5128 File Offset: 0x001D3328
		public new static vtkGenericVertexAttributeMapping New()
		{
			vtkGenericVertexAttributeMapping result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B66 RID: 84838 RVA: 0x001D517C File Offset: 0x001D337C
		public vtkGenericVertexAttributeMapping() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014B67 RID: 84839 RVA: 0x001D51C0 File Offset: 0x001D33C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014B68 RID: 84840
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericVertexAttributeMapping_AddMapping_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeName, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int fieldAssociation, int component);

		/// <summary>
		/// Select a data array from the point/cell data
		/// and map it to a generic vertex attribute.
		/// Note that indices change when a mapping is added/removed.
		/// </summary>
		// Token: 0x06014B69 RID: 84841 RVA: 0x001D51CB File Offset: 0x001D33CB
		public void AddMapping(string attributeName, string arrayName, int fieldAssociation, int component)
		{
			vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_AddMapping_01(base.GetCppThis(), attributeName, arrayName, fieldAssociation, component);
		}

		// Token: 0x06014B6A RID: 84842
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericVertexAttributeMapping_AddMapping_02(HandleRef pThis, int unit, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int fieldAssociation, int component);

		/// <summary>
		/// Select a data array and use it as multitexture texture
		/// coordinates.
		/// Note the texture unit parameter should correspond to the texture
		/// unit set on the texture.
		/// </summary>
		// Token: 0x06014B6B RID: 84843 RVA: 0x001D51DF File Offset: 0x001D33DF
		public void AddMapping(int unit, string arrayName, int fieldAssociation, int component)
		{
			vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_AddMapping_02(base.GetCppThis(), unit, arrayName, fieldAssociation, component);
		}

		// Token: 0x06014B6C RID: 84844
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_GetArrayName_03(HandleRef pThis, uint index);

		/// <summary>
		/// Get the array name at the given index.
		/// </summary>
		// Token: 0x06014B6D RID: 84845 RVA: 0x001D51F4 File Offset: 0x001D33F4
		public string GetArrayName(uint index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetArrayName_03(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014B6E RID: 84846
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_GetAttributeName_04(HandleRef pThis, uint index);

		/// <summary>
		/// Get the attribute name at the given index.
		/// </summary>
		// Token: 0x06014B6F RID: 84847 RVA: 0x001D5230 File Offset: 0x001D3430
		public string GetAttributeName(uint index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetAttributeName_04(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014B70 RID: 84848
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericVertexAttributeMapping_GetComponent_05(HandleRef pThis, uint index);

		/// <summary>
		/// Get the component no. at the given index.
		/// </summary>
		// Token: 0x06014B71 RID: 84849 RVA: 0x001D526C File Offset: 0x001D346C
		public int GetComponent(uint index)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetComponent_05(base.GetCppThis(), index);
		}

		// Token: 0x06014B72 RID: 84850
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericVertexAttributeMapping_GetFieldAssociation_06(HandleRef pThis, uint index);

		/// <summary>
		/// Get the field association at the given index.
		/// </summary>
		// Token: 0x06014B73 RID: 84851 RVA: 0x001D528C File Offset: 0x001D348C
		public int GetFieldAssociation(uint index)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetFieldAssociation_06(base.GetCppThis(), index);
		}

		// Token: 0x06014B74 RID: 84852
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B75 RID: 84853 RVA: 0x001D52AC File Offset: 0x001D34AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06014B76 RID: 84854
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B77 RID: 84855 RVA: 0x001D52CC File Offset: 0x001D34CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06014B78 RID: 84856
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGenericVertexAttributeMapping_GetNumberOfMappings_09(HandleRef pThis);

		/// <summary>
		/// Get number of mappings.
		/// </summary>
		// Token: 0x06014B79 RID: 84857 RVA: 0x001D52E8 File Offset: 0x001D34E8
		public uint GetNumberOfMappings()
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetNumberOfMappings_09(base.GetCppThis());
		}

		// Token: 0x06014B7A RID: 84858
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericVertexAttributeMapping_GetTextureUnit_10(HandleRef pThis, uint index);

		/// <summary>
		/// Get the component no. at the given index.
		/// </summary>
		// Token: 0x06014B7B RID: 84859 RVA: 0x001D5308 File Offset: 0x001D3508
		public int GetTextureUnit(uint index)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_GetTextureUnit_10(base.GetCppThis(), index);
		}

		// Token: 0x06014B7C RID: 84860
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericVertexAttributeMapping_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B7D RID: 84861 RVA: 0x001D5328 File Offset: 0x001D3528
		public override int IsA(string type)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06014B7E RID: 84862
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericVertexAttributeMapping_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B7F RID: 84863 RVA: 0x001D5348 File Offset: 0x001D3548
		public new static int IsTypeOf(string type)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_IsTypeOf_12(type);
		}

		// Token: 0x06014B80 RID: 84864
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B81 RID: 84865 RVA: 0x001D5364 File Offset: 0x001D3564
		public new vtkGenericVertexAttributeMapping NewInstance()
		{
			vtkGenericVertexAttributeMapping result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014B82 RID: 84866
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericVertexAttributeMapping_RemoveAllMappings_15(HandleRef pThis);

		/// <summary>
		/// Remove all mappings.
		/// </summary>
		// Token: 0x06014B83 RID: 84867 RVA: 0x001D53BE File Offset: 0x001D35BE
		public void RemoveAllMappings()
		{
			vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_RemoveAllMappings_15(base.GetCppThis());
		}

		// Token: 0x06014B84 RID: 84868
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenericVertexAttributeMapping_RemoveMapping_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeName);

		/// <summary>
		/// Remove a vertex attribute mapping.
		/// </summary>
		// Token: 0x06014B85 RID: 84869 RVA: 0x001D53D0 File Offset: 0x001D35D0
		public bool RemoveMapping(string attributeName)
		{
			return vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_RemoveMapping_16(base.GetCppThis(), attributeName) != 0;
		}

		// Token: 0x06014B86 RID: 84870
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericVertexAttributeMapping_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B87 RID: 84871 RVA: 0x001D53F8 File Offset: 0x001D35F8
		public new static vtkGenericVertexAttributeMapping SafeDownCast(vtkObjectBase o)
		{
			vtkGenericVertexAttributeMapping vtkGenericVertexAttributeMapping = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericVertexAttributeMapping.vtkGenericVertexAttributeMapping_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericVertexAttributeMapping = (vtkGenericVertexAttributeMapping)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericVertexAttributeMapping.Register(null);
				}
			}
			return vtkGenericVertexAttributeMapping;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017EF RID: 6127
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericVertexAttributeMapping";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017F0 RID: 6128
		public new static readonly string MRClassNameKey = "class vtkGenericVertexAttributeMapping";
	}
}
