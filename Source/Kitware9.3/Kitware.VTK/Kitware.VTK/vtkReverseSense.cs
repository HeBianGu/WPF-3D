using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReverseSense
	/// </summary>
	/// <remarks>
	///    reverse the ordering of polygonal cells and/or vertex normals
	///
	///
	/// vtkReverseSense is a filter that reverses the order of polygonal cells
	/// and/or reverses the direction of point and cell normals. Two flags are
	/// used to control these operations. Cell reversal means reversing the order
	/// of indices in the cell connectivity list. Normal reversal means
	/// multiplying the normal vector by -1 (both point and cell normals,
	/// if present).
	///
	/// @warning
	/// Normals can be operated on only if they are present in the data.
	/// </remarks>
	// Token: 0x0200099A RID: 2458
	public class vtkReverseSense : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019A69 RID: 105065 RVA: 0x0023A9D9 File Offset: 0x00238BD9
		static vtkReverseSense()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReverseSense.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReverseSense"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019A6A RID: 105066 RVA: 0x0023AA01 File Offset: 0x00238C01
		public vtkReverseSense(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019A6B RID: 105067
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReverseSense_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that behavior is to reverse cell ordering and
		/// leave normal orientation as is.
		/// </summary>
		// Token: 0x06019A6C RID: 105068 RVA: 0x0023AA10 File Offset: 0x00238C10
		public new static vtkReverseSense New()
		{
			vtkReverseSense result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReverseSense.vtkReverseSense_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object so that behavior is to reverse cell ordering and
		/// leave normal orientation as is.
		/// </summary>
		// Token: 0x06019A6D RID: 105069 RVA: 0x0023AA64 File Offset: 0x00238C64
		public vtkReverseSense() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkReverseSense.vtkReverseSense_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019A6E RID: 105070 RVA: 0x0023AAA8 File Offset: 0x00238CA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019A6F RID: 105071
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReverseSense_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A70 RID: 105072 RVA: 0x0023AAB4 File Offset: 0x00238CB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReverseSense.vtkReverseSense_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06019A71 RID: 105073
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReverseSense_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A72 RID: 105074 RVA: 0x0023AAD4 File Offset: 0x00238CD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReverseSense.vtkReverseSense_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06019A73 RID: 105075
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReverseSense_GetReverseCells_03(HandleRef pThis);

		/// <summary>
		/// Flag controls whether to reverse cell ordering.
		/// </summary>
		// Token: 0x06019A74 RID: 105076 RVA: 0x0023AAF0 File Offset: 0x00238CF0
		public virtual int GetReverseCells()
		{
			return vtkReverseSense.vtkReverseSense_GetReverseCells_03(base.GetCppThis());
		}

		// Token: 0x06019A75 RID: 105077
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReverseSense_GetReverseNormals_04(HandleRef pThis);

		/// <summary>
		/// Flag controls whether to reverse normal orientation.
		/// </summary>
		// Token: 0x06019A76 RID: 105078 RVA: 0x0023AB10 File Offset: 0x00238D10
		public virtual int GetReverseNormals()
		{
			return vtkReverseSense.vtkReverseSense_GetReverseNormals_04(base.GetCppThis());
		}

		// Token: 0x06019A77 RID: 105079
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReverseSense_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A78 RID: 105080 RVA: 0x0023AB30 File Offset: 0x00238D30
		public override int IsA(string type)
		{
			return vtkReverseSense.vtkReverseSense_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06019A79 RID: 105081
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReverseSense_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A7A RID: 105082 RVA: 0x0023AB50 File Offset: 0x00238D50
		public new static int IsTypeOf(string type)
		{
			return vtkReverseSense.vtkReverseSense_IsTypeOf_06(type);
		}

		// Token: 0x06019A7B RID: 105083
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReverseSense_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A7C RID: 105084 RVA: 0x0023AB6C File Offset: 0x00238D6C
		public new vtkReverseSense NewInstance()
		{
			vtkReverseSense result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReverseSense.vtkReverseSense_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019A7D RID: 105085
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReverseSense_ReverseCellsOff_09(HandleRef pThis);

		/// <summary>
		/// Flag controls whether to reverse cell ordering.
		/// </summary>
		// Token: 0x06019A7E RID: 105086 RVA: 0x0023ABC6 File Offset: 0x00238DC6
		public virtual void ReverseCellsOff()
		{
			vtkReverseSense.vtkReverseSense_ReverseCellsOff_09(base.GetCppThis());
		}

		// Token: 0x06019A7F RID: 105087
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReverseSense_ReverseCellsOn_10(HandleRef pThis);

		/// <summary>
		/// Flag controls whether to reverse cell ordering.
		/// </summary>
		// Token: 0x06019A80 RID: 105088 RVA: 0x0023ABD5 File Offset: 0x00238DD5
		public virtual void ReverseCellsOn()
		{
			vtkReverseSense.vtkReverseSense_ReverseCellsOn_10(base.GetCppThis());
		}

		// Token: 0x06019A81 RID: 105089
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReverseSense_ReverseNormalsOff_11(HandleRef pThis);

		/// <summary>
		/// Flag controls whether to reverse normal orientation.
		/// </summary>
		// Token: 0x06019A82 RID: 105090 RVA: 0x0023ABE4 File Offset: 0x00238DE4
		public virtual void ReverseNormalsOff()
		{
			vtkReverseSense.vtkReverseSense_ReverseNormalsOff_11(base.GetCppThis());
		}

		// Token: 0x06019A83 RID: 105091
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReverseSense_ReverseNormalsOn_12(HandleRef pThis);

		/// <summary>
		/// Flag controls whether to reverse normal orientation.
		/// </summary>
		// Token: 0x06019A84 RID: 105092 RVA: 0x0023ABF3 File Offset: 0x00238DF3
		public virtual void ReverseNormalsOn()
		{
			vtkReverseSense.vtkReverseSense_ReverseNormalsOn_12(base.GetCppThis());
		}

		// Token: 0x06019A85 RID: 105093
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReverseSense_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A86 RID: 105094 RVA: 0x0023AC04 File Offset: 0x00238E04
		public new static vtkReverseSense SafeDownCast(vtkObjectBase o)
		{
			vtkReverseSense vtkReverseSense = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReverseSense.vtkReverseSense_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReverseSense = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReverseSense.Register(null);
				}
			}
			return vtkReverseSense;
		}

		// Token: 0x06019A87 RID: 105095
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReverseSense_SetReverseCells_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag controls whether to reverse cell ordering.
		/// </summary>
		// Token: 0x06019A88 RID: 105096 RVA: 0x0023AC83 File Offset: 0x00238E83
		public virtual void SetReverseCells(int _arg)
		{
			vtkReverseSense.vtkReverseSense_SetReverseCells_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06019A89 RID: 105097
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReverseSense_SetReverseNormals_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag controls whether to reverse normal orientation.
		/// </summary>
		// Token: 0x06019A8A RID: 105098 RVA: 0x0023AC93 File Offset: 0x00238E93
		public virtual void SetReverseNormals(int _arg)
		{
			vtkReverseSense.vtkReverseSense_SetReverseNormals_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF9 RID: 7161
		public new const string MRFullTypeName = "Kitware.VTK.vtkReverseSense";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BFA RID: 7162
		public new static readonly string MRClassNameKey = "class vtkReverseSense";
	}
}
