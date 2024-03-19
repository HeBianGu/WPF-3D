using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    Interface for obtaining
	/// interpolated velocity values
	///
	/// vtkGenericInterpolatedVelocityField acts as a continuous velocity field
	/// by performing cell interpolation on the underlying vtkDataSet.
	/// This is a concrete sub-class of vtkFunctionSet with
	/// NumberOfIndependentVariables = 4 (x,y,z,t) and
	/// NumberOfFunctions = 3 (u,v,w). Normally, every time an evaluation
	/// is performed, the cell which contains the point (x,y,z) has to
	/// be found by calling FindCell. This is a computationally expansive
	/// operation. In certain cases, the cell search can be avoided or shortened
	/// by providing a guess for the cell iterator. For example, in streamline
	/// integration, the next evaluation is usually in the same or a neighbour
	/// cell. For this reason, vtkGenericInterpolatedVelocityField stores the last
	/// cell iterator. If caching is turned on, it uses this iterator as the
	/// starting point.
	///
	/// @warning
	/// vtkGenericInterpolatedVelocityField is not thread safe. A new instance
	/// should be created by each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFunctionSet vtkGenericStreamTracer
	/// </seealso>
	// Token: 0x02000A51 RID: 2641
	public class vtkGenericInterpolatedVelocityField : vtkFunctionSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B965 RID: 112997 RVA: 0x00269BCB File Offset: 0x00267DCB
		static vtkGenericInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B966 RID: 112998 RVA: 0x00269BF3 File Offset: 0x00267DF3
		public vtkGenericInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B967 RID: 112999
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkGenericInterpolatedVelocityField with no initial data set.
		/// Caching is on. LastCellId is set to -1.
		/// </summary>
		// Token: 0x0601B968 RID: 113000 RVA: 0x00269C04 File Offset: 0x00267E04
		public new static vtkGenericInterpolatedVelocityField New()
		{
			vtkGenericInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkGenericInterpolatedVelocityField with no initial data set.
		/// Caching is on. LastCellId is set to -1.
		/// </summary>
		// Token: 0x0601B969 RID: 113001 RVA: 0x00269C58 File Offset: 0x00267E58
		public vtkGenericInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B96A RID: 113002 RVA: 0x00269C9C File Offset: 0x00267E9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B96B RID: 113003
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset);

		/// <summary>
		/// Add a dataset used for the implicit function evaluation.
		/// If more than one dataset is added, the evaluation point is
		/// searched in all until a match is found. THIS FUNCTION
		/// DOES NOT CHANGE THE REFERENCE COUNT OF dataset FOR THREAD
		/// SAFETY REASONS.
		/// </summary>
		// Token: 0x0601B96C RID: 113004 RVA: 0x00269CA8 File Offset: 0x00267EA8
		public virtual void AddDataSet(vtkGenericDataSet dataset)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		// Token: 0x0601B96D RID: 113005
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_CachingOff_02(HandleRef pThis);

		/// <summary>
		/// Turn caching on/off.
		/// </summary>
		// Token: 0x0601B96E RID: 113006 RVA: 0x00269CD7 File Offset: 0x00267ED7
		public virtual void CachingOff()
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_CachingOff_02(base.GetCppThis());
		}

		// Token: 0x0601B96F RID: 113007
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_CachingOn_03(HandleRef pThis);

		/// <summary>
		/// Turn caching on/off.
		/// </summary>
		// Token: 0x0601B970 RID: 113008 RVA: 0x00269CE6 File Offset: 0x00267EE6
		public virtual void CachingOn()
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_CachingOn_03(base.GetCppThis());
		}

		// Token: 0x0601B971 RID: 113009
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_ClearLastCell_04(HandleRef pThis);

		/// <summary>
		/// Set the last cell id to -1 so that the next search does not
		/// start from the previous cell
		/// </summary>
		// Token: 0x0601B972 RID: 113010 RVA: 0x00269CF5 File Offset: 0x00267EF5
		public void ClearLastCell()
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_ClearLastCell_04(base.GetCppThis());
		}

		// Token: 0x0601B973 RID: 113011
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_CopyParameters_05(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy the user set parameters from source. This copies
		/// the Caching parameters. Sub-classes can add more after
		/// chaining.
		/// </summary>
		// Token: 0x0601B974 RID: 113012 RVA: 0x00269D04 File Offset: 0x00267F04
		public virtual void CopyParameters(vtkGenericInterpolatedVelocityField from)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_CopyParameters_05(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0601B975 RID: 113013
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_FunctionValues_06(HandleRef pThis, IntPtr x, IntPtr f);

		/// <summary>
		/// Evaluate the velocity field, f, at (x, y, z, t).
		/// For now, t is ignored.
		/// </summary>
		// Token: 0x0601B976 RID: 113014 RVA: 0x00269D34 File Offset: 0x00267F34
		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_FunctionValues_06(base.GetCppThis(), x, f);
		}

		// Token: 0x0601B977 RID: 113015
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_GetCacheHit_07(HandleRef pThis);

		/// <summary>
		/// Caching statistics.
		/// </summary>
		// Token: 0x0601B978 RID: 113016 RVA: 0x00269D58 File Offset: 0x00267F58
		public virtual int GetCacheHit()
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetCacheHit_07(base.GetCppThis());
		}

		// Token: 0x0601B979 RID: 113017
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_GetCacheMiss_08(HandleRef pThis);

		/// <summary>
		/// Caching statistics.
		/// </summary>
		// Token: 0x0601B97A RID: 113018 RVA: 0x00269D78 File Offset: 0x00267F78
		public virtual int GetCacheMiss()
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetCacheMiss_08(base.GetCppThis());
		}

		// Token: 0x0601B97B RID: 113019
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_GetCaching_09(HandleRef pThis);

		/// <summary>
		/// Turn caching on/off.
		/// </summary>
		// Token: 0x0601B97C RID: 113020 RVA: 0x00269D98 File Offset: 0x00267F98
		public virtual int GetCaching()
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetCaching_09(base.GetCppThis());
		}

		// Token: 0x0601B97D RID: 113021
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetLastCell_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the cell cached from last evaluation.
		/// </summary>
		// Token: 0x0601B97E RID: 113022 RVA: 0x00269DB8 File Offset: 0x00267FB8
		public vtkGenericAdaptorCell GetLastCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetLastCell_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		// Token: 0x0601B97F RID: 113023
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetLastDataSet_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the last dataset that was visited. Can be used
		/// as a first guess as to where the next point will be as
		/// well as to avoid searching through all datasets to get
		/// more information about the point.
		/// </summary>
		// Token: 0x0601B980 RID: 113024 RVA: 0x00269E28 File Offset: 0x00268028
		public virtual vtkGenericDataSet GetLastDataSet()
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetLastDataSet_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		// Token: 0x0601B981 RID: 113025
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_GetLastLocalCoordinates_12(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Returns the interpolation weights cached from last evaluation
		/// if the cached cell is valid (returns 1). Otherwise, it does not
		/// change w and returns 0.
		/// </summary>
		// Token: 0x0601B982 RID: 113026 RVA: 0x00269E98 File Offset: 0x00268098
		public int GetLastLocalCoordinates(IntPtr pcoords)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetLastLocalCoordinates_12(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B983 RID: 113027
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B984 RID: 113028 RVA: 0x00269EB8 File Offset: 0x002680B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B985 RID: 113029
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B986 RID: 113030 RVA: 0x00269ED8 File Offset: 0x002680D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601B987 RID: 113031
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_GetVectorsSelection_15(HandleRef pThis);

		/// <summary>
		/// If you want to work with an arbitrary vector array, then set its name
		/// here. By default this in nullptr and the filter will use the active vector
		/// array.
		/// </summary>
		// Token: 0x0601B988 RID: 113032 RVA: 0x00269EF4 File Offset: 0x002680F4
		public virtual string GetVectorsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_GetVectorsSelection_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B989 RID: 113033
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B98A RID: 113034 RVA: 0x00269F30 File Offset: 0x00268130
		public override int IsA(string type)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601B98B RID: 113035
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericInterpolatedVelocityField_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B98C RID: 113036 RVA: 0x00269F50 File Offset: 0x00268150
		public new static int IsTypeOf(string type)
		{
			return vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_IsTypeOf_17(type);
		}

		// Token: 0x0601B98D RID: 113037
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B98E RID: 113038 RVA: 0x00269F6C File Offset: 0x0026816C
		public new vtkGenericInterpolatedVelocityField NewInstance()
		{
			vtkGenericInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B98F RID: 113039
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericInterpolatedVelocityField_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B990 RID: 113040 RVA: 0x00269FC8 File Offset: 0x002681C8
		public new static vtkGenericInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkGenericInterpolatedVelocityField vtkGenericInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericInterpolatedVelocityField = (vtkGenericInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericInterpolatedVelocityField.Register(null);
				}
			}
			return vtkGenericInterpolatedVelocityField;
		}

		// Token: 0x0601B991 RID: 113041
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_SelectVectors_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to work with an arbitrary vector array, then set its name
		/// here. By default this in nullptr and the filter will use the active vector
		/// array.
		/// </summary>
		// Token: 0x0601B992 RID: 113042 RVA: 0x0026A047 File Offset: 0x00268247
		public void SelectVectors(string fieldName)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_SelectVectors_21(base.GetCppThis(), fieldName);
		}

		// Token: 0x0601B993 RID: 113043
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericInterpolatedVelocityField_SetCaching_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn caching on/off.
		/// </summary>
		// Token: 0x0601B994 RID: 113044 RVA: 0x0026A057 File Offset: 0x00268257
		public virtual void SetCaching(int _arg)
		{
			vtkGenericInterpolatedVelocityField.vtkGenericInterpolatedVelocityField_SetCaching_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D96 RID: 7574
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D97 RID: 7575
		public new static readonly string MRClassNameKey = "class vtkGenericInterpolatedVelocityField";
	}
}
