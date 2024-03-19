using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationQuadratureSchemeDefinitionVectorKey
	/// </summary>
	/// <remarks>
	///    Key for vtkQuadratureSchemeDefinition vector values.
	///
	/// vtkInformationQuadratureSchemeDefinitionVectorKey is used to represent keys for double
	/// vector values in vtkInformation.h. NOTE the interface in this key differs
	/// from that in other similar keys because of our internal use of smart
	/// pointers.
	/// </remarks>
	// Token: 0x02000A71 RID: 2673
	public class vtkInformationQuadratureSchemeDefinitionVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BFF3 RID: 114675 RVA: 0x002739AB File Offset: 0x00271BAB
		static vtkInformationQuadratureSchemeDefinitionVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationQuadratureSchemeDefinitionVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationQuadratureSchemeDefinitionVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BFF4 RID: 114676 RVA: 0x002739D3 File Offset: 0x00271BD3
		public vtkInformationQuadratureSchemeDefinitionVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BFF5 RID: 114677 RVA: 0x002739E1 File Offset: 0x00271BE1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BFF6 RID: 114678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Put the value on the back of the vector, with reference counting.
		/// </summary>
		// Token: 0x0601BFF7 RID: 114679 RVA: 0x002739EC File Offset: 0x00271BEC
		public void Append(vtkInformation info, vtkQuadratureSchemeDefinition value)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601BFF8 RID: 114680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Clear_02(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Clear the vector.
		/// </summary>
		// Token: 0x0601BFF9 RID: 114681 RVA: 0x00273A30 File Offset: 0x00271C30
		public void Clear(vtkInformation info)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Clear_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601BFFA RID: 114682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_DeepCopy_03(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601BFFB RID: 114683 RVA: 0x00273A60 File Offset: 0x00271C60
		public override void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_DeepCopy_03(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x0601BFFC RID: 114684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_Get_04(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkQuadratureSchemeDefinition at a specific location in the vector.
		/// </summary>
		// Token: 0x0601BFFD RID: 114685 RVA: 0x00273AA4 File Offset: 0x00271CA4
		public vtkQuadratureSchemeDefinition Get(vtkInformation info, int idx)
		{
			vtkQuadratureSchemeDefinition vtkQuadratureSchemeDefinition = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadratureSchemeDefinition = (vtkQuadratureSchemeDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadratureSchemeDefinition.Register(null);
				}
			}
			return vtkQuadratureSchemeDefinition;
		}

		// Token: 0x0601BFFE RID: 114686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFFF RID: 114687 RVA: 0x00273B2C File Offset: 0x00271D2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601C000 RID: 114688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C001 RID: 114689 RVA: 0x00273B4C File Offset: 0x00271D4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601C002 RID: 114690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C003 RID: 114691 RVA: 0x00273B68 File Offset: 0x00271D68
		public override int IsA(string type)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C004 RID: 114692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C005 RID: 114693 RVA: 0x00273B88 File Offset: 0x00271D88
		public new static int IsTypeOf(string type)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_IsTypeOf_08(type);
		}

		// Token: 0x0601C006 RID: 114694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_Length_09(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get the vector's length.
		/// </summary>
		// Token: 0x0601C007 RID: 114695 RVA: 0x00273BA4 File Offset: 0x00271DA4
		public int Length(vtkInformation info)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Length_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601C008 RID: 114696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C009 RID: 114697 RVA: 0x00273BD8 File Offset: 0x00271DD8
		public new vtkInformationQuadratureSchemeDefinitionVectorKey NewInstance()
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C00A RID: 114698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Resize_11(HandleRef pThis, HandleRef info, int n);

		/// <summary>
		/// Resize (extend) the vector to hold n objects. Any new elements
		/// created will be null initialized.
		/// </summary>
		// Token: 0x0601C00B RID: 114699 RVA: 0x00273C34 File Offset: 0x00271E34
		public void Resize(vtkInformation info, int n)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Resize_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), n);
		}

		// Token: 0x0601C00C RID: 114700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_RestoreState_12(HandleRef pThis, HandleRef info, HandleRef element);

		/// <summary>
		/// Load key/value pairs from an XML state representation created
		/// with SaveState. Duplicate keys will generate a fatal error.
		/// </summary>
		// Token: 0x0601C00D RID: 114701 RVA: 0x00273C64 File Offset: 0x00271E64
		public int RestoreState(vtkInformation info, vtkXMLDataElement element)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_RestoreState_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis());
		}

		// Token: 0x0601C00E RID: 114702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationQuadratureSchemeDefinitionVectorKey_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C00F RID: 114703 RVA: 0x00273CB0 File Offset: 0x00271EB0
		public new static vtkInformationQuadratureSchemeDefinitionVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey vtkInformationQuadratureSchemeDefinitionVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationQuadratureSchemeDefinitionVectorKey = (vtkInformationQuadratureSchemeDefinitionVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationQuadratureSchemeDefinitionVectorKey.Register(null);
				}
			}
			return vtkInformationQuadratureSchemeDefinitionVectorKey;
		}

		// Token: 0x0601C010 RID: 114704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_SaveState_14(HandleRef pThis, HandleRef info, HandleRef element);

		/// <summary>
		/// Generate an XML representation of the object. Each
		/// key/value pair will be nested in the resulting XML hierarchy.
		/// The element passed in is assumed to be empty.
		/// </summary>
		// Token: 0x0601C011 RID: 114705 RVA: 0x00273D30 File Offset: 0x00271F30
		public int SaveState(vtkInformation info, vtkXMLDataElement element)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_SaveState_14(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis());
		}

		// Token: 0x0601C012 RID: 114706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_Set_15(HandleRef pThis, HandleRef info, HandleRef value, int i);

		/// <summary>
		/// Set element i of the vector to value. Resizes the vector
		/// if needed.
		/// </summary>
		// Token: 0x0601C013 RID: 114707 RVA: 0x00273D7C File Offset: 0x00271F7C
		public void Set(vtkInformation info, vtkQuadratureSchemeDefinition value, int i)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Set_15(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), i);
		}

		// Token: 0x0601C014 RID: 114708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationQuadratureSchemeDefinitionVectorKey_ShallowCopy_16(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601C015 RID: 114709 RVA: 0x00273DC4 File Offset: 0x00271FC4
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_ShallowCopy_16(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x0601C016 RID: 114710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationQuadratureSchemeDefinitionVectorKey_Size_17(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get the vector's length.
		/// </summary>
		// Token: 0x0601C017 RID: 114711 RVA: 0x00273E08 File Offset: 0x00272008
		public int Size(vtkInformation info)
		{
			return vtkInformationQuadratureSchemeDefinitionVectorKey.vtkInformationQuadratureSchemeDefinitionVectorKey_Size_17(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD9 RID: 7641
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationQuadratureSchemeDefinitionVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DDA RID: 7642
		public new static readonly string MRClassNameKey = "class vtkInformationQuadratureSchemeDefinitionVectorKey";
	}
}
