using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendArcLength
	/// </summary>
	/// <remarks>
	///    appends Arc length for input poly lines.
	///
	/// vtkAppendArcLength is used for filter such as plot-over-line. In such cases,
	/// we need to add an attribute array that is the arc_length over the length of
	/// the probed line. That's when vtkAppendArcLength can be used. It adds a new
	/// point-data array named "arc_length" with the computed arc length for each of
	/// the polylines in the input. For all other cell types, the arc length is set
	/// to 0.
	/// @warning
	/// This filter assumes that cells don't share points.
	/// </remarks>
	// Token: 0x02000936 RID: 2358
	public class vtkAppendArcLength : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060186B8 RID: 100024 RVA: 0x0022281F File Offset: 0x00220A1F
		static vtkAppendArcLength()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendArcLength.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendArcLength"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060186B9 RID: 100025 RVA: 0x00222847 File Offset: 0x00220A47
		public vtkAppendArcLength(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060186BA RID: 100026
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendArcLength_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186BB RID: 100027 RVA: 0x00222858 File Offset: 0x00220A58
		public new static vtkAppendArcLength New()
		{
			vtkAppendArcLength result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendArcLength.vtkAppendArcLength_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendArcLength)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186BC RID: 100028 RVA: 0x002228AC File Offset: 0x00220AAC
		public vtkAppendArcLength() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendArcLength.vtkAppendArcLength_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060186BD RID: 100029 RVA: 0x002228F0 File Offset: 0x00220AF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060186BE RID: 100030
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendArcLength_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186BF RID: 100031 RVA: 0x002228FC File Offset: 0x00220AFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendArcLength.vtkAppendArcLength_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060186C0 RID: 100032
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendArcLength_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186C1 RID: 100033 RVA: 0x0022291C File Offset: 0x00220B1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendArcLength.vtkAppendArcLength_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060186C2 RID: 100034
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendArcLength_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186C3 RID: 100035 RVA: 0x00222938 File Offset: 0x00220B38
		public override int IsA(string type)
		{
			return vtkAppendArcLength.vtkAppendArcLength_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060186C4 RID: 100036
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendArcLength_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186C5 RID: 100037 RVA: 0x00222958 File Offset: 0x00220B58
		public new static int IsTypeOf(string type)
		{
			return vtkAppendArcLength.vtkAppendArcLength_IsTypeOf_04(type);
		}

		// Token: 0x060186C6 RID: 100038
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendArcLength_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186C7 RID: 100039 RVA: 0x00222974 File Offset: 0x00220B74
		public new vtkAppendArcLength NewInstance()
		{
			vtkAppendArcLength result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendArcLength.vtkAppendArcLength_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendArcLength)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060186C8 RID: 100040
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendArcLength_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186C9 RID: 100041 RVA: 0x002229D0 File Offset: 0x00220BD0
		public new static vtkAppendArcLength SafeDownCast(vtkObjectBase o)
		{
			vtkAppendArcLength vtkAppendArcLength = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendArcLength.vtkAppendArcLength_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendArcLength = (vtkAppendArcLength)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendArcLength.Register(null);
				}
			}
			return vtkAppendArcLength;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B16 RID: 6934
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendArcLength";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B17 RID: 6935
		public new static readonly string MRClassNameKey = "class vtkAppendArcLength";
	}
}
