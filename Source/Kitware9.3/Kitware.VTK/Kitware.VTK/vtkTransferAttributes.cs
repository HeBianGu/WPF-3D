using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransferAttributes
	/// </summary>
	/// <remarks>
	///    transfer data from a graph representation
	/// to a tree representation using direct mapping or pedigree ids.
	///
	///
	/// The filter requires
	/// both a vtkGraph and vtkTree as input.  The tree vertices must be a
	/// superset of the graph vertices.  A common example is when the graph vertices
	/// correspond to the leaves of the tree, but the internal vertices of the tree
	/// represent groupings of graph vertices.  The algorithm matches the vertices
	/// using the array "PedigreeId".  The user may alternately set the
	/// DirectMapping flag to indicate that the two structures must have directly
	/// corresponding offsets (i.e. node i in the graph must correspond to node i in
	/// the tree).
	///
	/// </remarks>
	// Token: 0x0200069B RID: 1691
	public class vtkTransferAttributes : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601219F RID: 74143 RVA: 0x001958AD File Offset: 0x00193AAD
		static vtkTransferAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransferAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransferAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060121A0 RID: 74144 RVA: 0x001958D5 File Offset: 0x00193AD5
		public vtkTransferAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060121A1 RID: 74145
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransferAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121A2 RID: 74146 RVA: 0x001958E4 File Offset: 0x00193AE4
		public new static vtkTransferAttributes New()
		{
			vtkTransferAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121A3 RID: 74147 RVA: 0x00195938 File Offset: 0x00193B38
		public vtkTransferAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransferAttributes.vtkTransferAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060121A4 RID: 74148 RVA: 0x0019597C File Offset: 0x00193B7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060121A5 RID: 74149
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_DirectMappingOff_01(HandleRef pThis);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x060121A6 RID: 74150 RVA: 0x00195987 File Offset: 0x00193B87
		public virtual void DirectMappingOff()
		{
			vtkTransferAttributes.vtkTransferAttributes_DirectMappingOff_01(base.GetCppThis());
		}

		// Token: 0x060121A7 RID: 74151
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_DirectMappingOn_02(HandleRef pThis);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x060121A8 RID: 74152 RVA: 0x00195996 File Offset: 0x00193B96
		public virtual void DirectMappingOn()
		{
			vtkTransferAttributes.vtkTransferAttributes_DirectMappingOn_02(base.GetCppThis());
		}

		// Token: 0x060121A9 RID: 74153
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransferAttributes_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set the input type of the algorithm to vtkGraph.
		/// </summary>
		// Token: 0x060121AA RID: 74154 RVA: 0x001959A8 File Offset: 0x00193BA8
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkTransferAttributes.vtkTransferAttributes_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x060121AB RID: 74155
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransferAttributes_GetDefaultValue_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Method to get/set the default value.
		/// </summary>
		// Token: 0x060121AC RID: 74156 RVA: 0x001959E0 File Offset: 0x00193BE0
		public vtkVariant GetDefaultValue()
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_GetDefaultValue_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060121AD RID: 74157
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTransferAttributes_GetDirectMapping_05(HandleRef pThis);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x060121AE RID: 74158 RVA: 0x00195A3C File Offset: 0x00193C3C
		public virtual bool GetDirectMapping()
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetDirectMapping_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060121AF RID: 74159
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransferAttributes_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121B0 RID: 74160 RVA: 0x00195A64 File Offset: 0x00193C64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060121B1 RID: 74161
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransferAttributes_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121B2 RID: 74162 RVA: 0x00195A84 File Offset: 0x00193C84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060121B3 RID: 74163
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransferAttributes_GetSourceArrayName_08(HandleRef pThis);

		/// <summary>
		/// The field name to use for storing the source array.
		/// </summary>
		// Token: 0x060121B4 RID: 74164 RVA: 0x00195AA0 File Offset: 0x00193CA0
		public virtual string GetSourceArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTransferAttributes.vtkTransferAttributes_GetSourceArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060121B5 RID: 74165
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransferAttributes_GetSourceFieldType_09(HandleRef pThis);

		/// <summary>
		/// The source field type for accessing the source array. Valid values are
		/// those from enum vtkDataObject::FieldAssociations.
		/// </summary>
		// Token: 0x060121B6 RID: 74166 RVA: 0x00195ADC File Offset: 0x00193CDC
		public virtual int GetSourceFieldType()
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetSourceFieldType_09(base.GetCppThis());
		}

		// Token: 0x060121B7 RID: 74167
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransferAttributes_GetTargetArrayName_10(HandleRef pThis);

		/// <summary>
		/// The field name to use for storing the source array.
		/// </summary>
		// Token: 0x060121B8 RID: 74168 RVA: 0x00195AFC File Offset: 0x00193CFC
		public virtual string GetTargetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTransferAttributes.vtkTransferAttributes_GetTargetArrayName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060121B9 RID: 74169
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransferAttributes_GetTargetFieldType_11(HandleRef pThis);

		/// <summary>
		/// The target field type for accessing the target array. Valid values are
		/// those from enum vtkDataObject::FieldAssociations.
		/// </summary>
		// Token: 0x060121BA RID: 74170 RVA: 0x00195B38 File Offset: 0x00193D38
		public virtual int GetTargetFieldType()
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetTargetFieldType_11(base.GetCppThis());
		}

		// Token: 0x060121BB RID: 74171
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransferAttributes_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121BC RID: 74172 RVA: 0x00195B58 File Offset: 0x00193D58
		public override int IsA(string type)
		{
			return vtkTransferAttributes.vtkTransferAttributes_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060121BD RID: 74173
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransferAttributes_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121BE RID: 74174 RVA: 0x00195B78 File Offset: 0x00193D78
		public new static int IsTypeOf(string type)
		{
			return vtkTransferAttributes.vtkTransferAttributes_IsTypeOf_13(type);
		}

		// Token: 0x060121BF RID: 74175
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransferAttributes_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121C0 RID: 74176 RVA: 0x00195B94 File Offset: 0x00193D94
		public new vtkTransferAttributes NewInstance()
		{
			vtkTransferAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060121C1 RID: 74177
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransferAttributes_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a vtkTransferAttributes object.
		/// Initial values are DirectMapping = false, DefaultValue = 1,
		/// SourceArrayName=0, TargetArrayName = 0,
		/// SourceFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS,
		/// TargetFieldType=vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// </summary>
		// Token: 0x060121C2 RID: 74178 RVA: 0x00195BF0 File Offset: 0x00193DF0
		public new static vtkTransferAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkTransferAttributes vtkTransferAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransferAttributes = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransferAttributes.Register(null);
				}
			}
			return vtkTransferAttributes;
		}

		// Token: 0x060121C3 RID: 74179
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_SetDefaultValue_17(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Method to get/set the default value.
		/// </summary>
		// Token: 0x060121C4 RID: 74180 RVA: 0x00195C70 File Offset: 0x00193E70
		public void SetDefaultValue(vtkVariant value)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetDefaultValue_17(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x060121C5 RID: 74181
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_SetDirectMapping_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x060121C6 RID: 74182 RVA: 0x00195C9F File Offset: 0x00193E9F
		public virtual void SetDirectMapping(bool _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetDirectMapping_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060121C7 RID: 74183
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_SetSourceArrayName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The field name to use for storing the source array.
		/// </summary>
		// Token: 0x060121C8 RID: 74184 RVA: 0x00195CB7 File Offset: 0x00193EB7
		public virtual void SetSourceArrayName(string _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetSourceArrayName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060121C9 RID: 74185
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_SetSourceFieldType_20(HandleRef pThis, int _arg);

		/// <summary>
		/// The source field type for accessing the source array. Valid values are
		/// those from enum vtkDataObject::FieldAssociations.
		/// </summary>
		// Token: 0x060121CA RID: 74186 RVA: 0x00195CC7 File Offset: 0x00193EC7
		public virtual void SetSourceFieldType(int _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetSourceFieldType_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060121CB RID: 74187
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_SetTargetArrayName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The field name to use for storing the source array.
		/// </summary>
		// Token: 0x060121CC RID: 74188 RVA: 0x00195CD7 File Offset: 0x00193ED7
		public virtual void SetTargetArrayName(string _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetTargetArrayName_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060121CD RID: 74189
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransferAttributes_SetTargetFieldType_22(HandleRef pThis, int _arg);

		/// <summary>
		/// The target field type for accessing the target array. Valid values are
		/// those from enum vtkDataObject::FieldAssociations.
		/// </summary>
		// Token: 0x060121CE RID: 74190 RVA: 0x00195CE7 File Offset: 0x00193EE7
		public virtual void SetTargetFieldType(int _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetTargetFieldType_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014E4 RID: 5348
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransferAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014E5 RID: 5349
		public new static readonly string MRClassNameKey = "class vtkTransferAttributes";
	}
}
