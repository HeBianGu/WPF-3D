using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMapArrayValues
	/// </summary>
	/// <remarks>
	///    Map values in an input array to different values in
	///   an output array of (possibly) different type.
	///
	///
	/// vtkMapArrayValues allows you to associate certain values of an attribute array
	/// (on either a vertex, edge, point, or cell) with different values in a
	/// newly created attribute array.
	///
	/// vtkMapArrayValues manages an internal STL map of vtkVariants that can be added to
	/// or cleared. When this filter executes, each "key" is searched for in the
	/// input array and the indices of the output array at which there were matches
	/// the set to the mapped "value".
	///
	/// You can control whether the input array values are passed to the output
	/// before the mapping occurs (using PassArray) or, if not, what value to set
	/// the unmapped indices to (using FillValue).
	///
	/// One application of this filter is to help address the dirty data problem.
	/// For example, using vtkMapArrayValues you could associate the vertex values
	/// "Foo, John", "Foo, John.", and "John Foo" with a single entity.
	/// </remarks>
	// Token: 0x020007F3 RID: 2035
	public class vtkMapArrayValues : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014EB2 RID: 85682 RVA: 0x001D96BF File Offset: 0x001D78BF
		static vtkMapArrayValues()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapArrayValues.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapArrayValues"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014EB3 RID: 85683 RVA: 0x001D96E7 File Offset: 0x001D78E7
		public vtkMapArrayValues(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014EB4 RID: 85684
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapArrayValues_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EB5 RID: 85685 RVA: 0x001D96F8 File Offset: 0x001D78F8
		public new static vtkMapArrayValues New()
		{
			vtkMapArrayValues result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapArrayValues.vtkMapArrayValues_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EB6 RID: 85686 RVA: 0x001D974C File Offset: 0x001D794C
		public vtkMapArrayValues() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMapArrayValues.vtkMapArrayValues_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014EB7 RID: 85687 RVA: 0x001D9790 File Offset: 0x001D7990
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014EB8 RID: 85688
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_AddToMap_01(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Add to the internal STL map. "from" should be a value in the input array and
		/// "to" should be the new value it gets assigned in the output array.
		/// </summary>
		// Token: 0x06014EB9 RID: 85689 RVA: 0x001D979C File Offset: 0x001D799C
		public void AddToMap(vtkVariant from, vtkVariant to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x06014EBA RID: 85690
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_AddToMap_02(HandleRef pThis, int from, int to);

		/// <summary>
		/// Add to the internal STL map. "from" should be a value in the input array and
		/// "to" should be the new value it gets assigned in the output array.
		/// </summary>
		// Token: 0x06014EBB RID: 85691 RVA: 0x001D97E0 File Offset: 0x001D79E0
		public void AddToMap(int from, int to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_02(base.GetCppThis(), from, to);
		}

		// Token: 0x06014EBC RID: 85692
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_AddToMap_03(HandleRef pThis, int from, [MarshalAs(UnmanagedType.LPUTF8Str)] string to);

		/// <summary>
		/// Add to the internal STL map. "from" should be a value in the input array and
		/// "to" should be the new value it gets assigned in the output array.
		/// </summary>
		// Token: 0x06014EBD RID: 85693 RVA: 0x001D97F1 File Offset: 0x001D79F1
		public void AddToMap(int from, string to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_03(base.GetCppThis(), from, to);
		}

		// Token: 0x06014EBE RID: 85694
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_AddToMap_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string from, int to);

		/// <summary>
		/// Add to the internal STL map. "from" should be a value in the input array and
		/// "to" should be the new value it gets assigned in the output array.
		/// </summary>
		// Token: 0x06014EBF RID: 85695 RVA: 0x001D9802 File Offset: 0x001D7A02
		public void AddToMap(string from, int to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_04(base.GetCppThis(), from, to);
		}

		// Token: 0x06014EC0 RID: 85696
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_AddToMap_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string from, [MarshalAs(UnmanagedType.LPUTF8Str)] string to);

		/// <summary>
		/// Add to the internal STL map. "from" should be a value in the input array and
		/// "to" should be the new value it gets assigned in the output array.
		/// </summary>
		// Token: 0x06014EC1 RID: 85697 RVA: 0x001D9813 File Offset: 0x001D7A13
		public void AddToMap(string from, string to)
		{
			vtkMapArrayValues.vtkMapArrayValues_AddToMap_05(base.GetCppThis(), from, to);
		}

		// Token: 0x06014EC2 RID: 85698
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_ClearMap_06(HandleRef pThis);

		/// <summary>
		/// Clear the internal map.
		/// </summary>
		// Token: 0x06014EC3 RID: 85699 RVA: 0x001D9824 File Offset: 0x001D7A24
		public void ClearMap()
		{
			vtkMapArrayValues.vtkMapArrayValues_ClearMap_06(base.GetCppThis());
		}

		// Token: 0x06014EC4 RID: 85700
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapArrayValues_GetFieldType_07(HandleRef pThis);

		/// <summary>
		/// Set/Get where the data is located that is being mapped.
		/// See FieldType enumeration for possible values.
		/// Default is POINT_DATA.
		/// </summary>
		// Token: 0x06014EC5 RID: 85701 RVA: 0x001D9834 File Offset: 0x001D7A34
		public virtual int GetFieldType()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetFieldType_07(base.GetCppThis());
		}

		// Token: 0x06014EC6 RID: 85702
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMapArrayValues_GetFillValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to copy the data from the input array to the output array
		/// before the mapping occurs. If turned off, FillValue is used to initialize
		/// any unmapped array indices. Default is -1.
		/// </summary>
		// Token: 0x06014EC7 RID: 85703 RVA: 0x001D9854 File Offset: 0x001D7A54
		public virtual double GetFillValue()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetFillValue_08(base.GetCppThis());
		}

		// Token: 0x06014EC8 RID: 85704
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapArrayValues_GetInputArrayName_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the input array. This must be set prior to execution.
		/// </summary>
		// Token: 0x06014EC9 RID: 85705 RVA: 0x001D9874 File Offset: 0x001D7A74
		public virtual string GetInputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMapArrayValues.vtkMapArrayValues_GetInputArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014ECA RID: 85706
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapArrayValues_GetMapSize_10(HandleRef pThis);

		/// <summary>
		/// Get the size of the internal map.
		/// </summary>
		// Token: 0x06014ECB RID: 85707 RVA: 0x001D98B0 File Offset: 0x001D7AB0
		public int GetMapSize()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetMapSize_10(base.GetCppThis());
		}

		// Token: 0x06014ECC RID: 85708
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapArrayValues_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014ECD RID: 85709 RVA: 0x001D98D0 File Offset: 0x001D7AD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06014ECE RID: 85710
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapArrayValues_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014ECF RID: 85711 RVA: 0x001D98F0 File Offset: 0x001D7AF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06014ED0 RID: 85712
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapArrayValues_GetOutputArrayName_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the output array. Default is "ArrayMap".
		/// </summary>
		// Token: 0x06014ED1 RID: 85713 RVA: 0x001D990C File Offset: 0x001D7B0C
		public virtual string GetOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMapArrayValues.vtkMapArrayValues_GetOutputArrayName_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014ED2 RID: 85714
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapArrayValues_GetOutputArrayType_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of the output array. See vtkSetGet.h for possible values.
		/// Default is VTK_INT.
		/// </summary>
		// Token: 0x06014ED3 RID: 85715 RVA: 0x001D9948 File Offset: 0x001D7B48
		public virtual int GetOutputArrayType()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetOutputArrayType_14(base.GetCppThis());
		}

		// Token: 0x06014ED4 RID: 85716
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapArrayValues_GetPassArray_15(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to copy the data from the input array to the output array
		/// before the mapping occurs. If turned off, FillValue is used to initialize
		/// any unmapped array indices. Default is off.
		/// </summary>
		// Token: 0x06014ED5 RID: 85717 RVA: 0x001D9968 File Offset: 0x001D7B68
		public virtual int GetPassArray()
		{
			return vtkMapArrayValues.vtkMapArrayValues_GetPassArray_15(base.GetCppThis());
		}

		// Token: 0x06014ED6 RID: 85718
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapArrayValues_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014ED7 RID: 85719 RVA: 0x001D9988 File Offset: 0x001D7B88
		public override int IsA(string type)
		{
			return vtkMapArrayValues.vtkMapArrayValues_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06014ED8 RID: 85720
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapArrayValues_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014ED9 RID: 85721 RVA: 0x001D99A8 File Offset: 0x001D7BA8
		public new static int IsTypeOf(string type)
		{
			return vtkMapArrayValues.vtkMapArrayValues_IsTypeOf_17(type);
		}

		// Token: 0x06014EDA RID: 85722
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapArrayValues_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EDB RID: 85723 RVA: 0x001D99C4 File Offset: 0x001D7BC4
		public new vtkMapArrayValues NewInstance()
		{
			vtkMapArrayValues result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapArrayValues.vtkMapArrayValues_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014EDC RID: 85724
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_PassArrayOff_20(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to copy the data from the input array to the output array
		/// before the mapping occurs. If turned off, FillValue is used to initialize
		/// any unmapped array indices. Default is off.
		/// </summary>
		// Token: 0x06014EDD RID: 85725 RVA: 0x001D9A1E File Offset: 0x001D7C1E
		public virtual void PassArrayOff()
		{
			vtkMapArrayValues.vtkMapArrayValues_PassArrayOff_20(base.GetCppThis());
		}

		// Token: 0x06014EDE RID: 85726
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_PassArrayOn_21(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to copy the data from the input array to the output array
		/// before the mapping occurs. If turned off, FillValue is used to initialize
		/// any unmapped array indices. Default is off.
		/// </summary>
		// Token: 0x06014EDF RID: 85727 RVA: 0x001D9A2D File Offset: 0x001D7C2D
		public virtual void PassArrayOn()
		{
			vtkMapArrayValues.vtkMapArrayValues_PassArrayOn_21(base.GetCppThis());
		}

		// Token: 0x06014EE0 RID: 85728
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapArrayValues_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EE1 RID: 85729 RVA: 0x001D9A3C File Offset: 0x001D7C3C
		public new static vtkMapArrayValues SafeDownCast(vtkObjectBase o)
		{
			vtkMapArrayValues vtkMapArrayValues = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapArrayValues.vtkMapArrayValues_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapArrayValues = (vtkMapArrayValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapArrayValues.Register(null);
				}
			}
			return vtkMapArrayValues;
		}

		// Token: 0x06014EE2 RID: 85730
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_SetFieldType_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get where the data is located that is being mapped.
		/// See FieldType enumeration for possible values.
		/// Default is POINT_DATA.
		/// </summary>
		// Token: 0x06014EE3 RID: 85731 RVA: 0x001D9ABB File Offset: 0x001D7CBB
		public virtual void SetFieldType(int _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetFieldType_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06014EE4 RID: 85732
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_SetFillValue_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get whether to copy the data from the input array to the output array
		/// before the mapping occurs. If turned off, FillValue is used to initialize
		/// any unmapped array indices. Default is -1.
		/// </summary>
		// Token: 0x06014EE5 RID: 85733 RVA: 0x001D9ACB File Offset: 0x001D7CCB
		public virtual void SetFillValue(double _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetFillValue_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06014EE6 RID: 85734
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_SetInputArrayName_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the input array. This must be set prior to execution.
		/// </summary>
		// Token: 0x06014EE7 RID: 85735 RVA: 0x001D9ADB File Offset: 0x001D7CDB
		public virtual void SetInputArrayName(string _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetInputArrayName_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06014EE8 RID: 85736
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_SetOutputArrayName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the output array. Default is "ArrayMap".
		/// </summary>
		// Token: 0x06014EE9 RID: 85737 RVA: 0x001D9AEB File Offset: 0x001D7CEB
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetOutputArrayName_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06014EEA RID: 85738
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_SetOutputArrayType_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the type of the output array. See vtkSetGet.h for possible values.
		/// Default is VTK_INT.
		/// </summary>
		// Token: 0x06014EEB RID: 85739 RVA: 0x001D9AFB File Offset: 0x001D7CFB
		public virtual void SetOutputArrayType(int _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetOutputArrayType_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06014EEC RID: 85740
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapArrayValues_SetPassArray_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether to copy the data from the input array to the output array
		/// before the mapping occurs. If turned off, FillValue is used to initialize
		/// any unmapped array indices. Default is off.
		/// </summary>
		// Token: 0x06014EED RID: 85741 RVA: 0x001D9B0B File Offset: 0x001D7D0B
		public virtual void SetPassArray(int _arg)
		{
			vtkMapArrayValues.vtkMapArrayValues_SetPassArray_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001825 RID: 6181
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapArrayValues";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001826 RID: 6182
		public new static readonly string MRClassNameKey = "class vtkMapArrayValues";

		/// <summary>
		/// Get the size of the internal map.
		/// </summary>
		// Token: 0x020007F4 RID: 2036
		public enum FieldType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001828 RID: 6184
			CELL_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001829 RID: 6185
			EDGE_DATA = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400182A RID: 6186
			NUM_ATTRIBUTE_LOCS = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400182B RID: 6187
			POINT_DATA = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400182C RID: 6188
			ROW_DATA = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400182D RID: 6189
			VERTEX_DATA = 2
		}
	}
}
