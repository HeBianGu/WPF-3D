using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridPointProbe
	/// </summary>
	/// <remarks>
	///    Probe a vtkCellGrid with points.
	///
	/// Given the following
	/// + an input polydata, P;
	/// + an input cell-grid, C; and
	/// + optionally, a cell-attribute, A, of input C
	/// produce an output polydata containing the
	/// points from P that lie inside C and have values of A interpolated to them.
	///
	/// Note that points of P may be repeated in the output if they are contained
	/// in multiple cells of C (i.e., because multiple cells overlap some points).
	/// This is most likely to occur at/near boundaries of cells in C.
	/// </remarks>
	// Token: 0x020004CE RID: 1230
	public class vtkCellGridPointProbe : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E042 RID: 57410 RVA: 0x0013709B File Offset: 0x0013529B
		static vtkCellGridPointProbe()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridPointProbe.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridPointProbe"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E043 RID: 57411 RVA: 0x001370C3 File Offset: 0x001352C3
		public vtkCellGridPointProbe(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E044 RID: 57412
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridPointProbe_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E045 RID: 57413 RVA: 0x001370D4 File Offset: 0x001352D4
		public new static vtkCellGridPointProbe New()
		{
			vtkCellGridPointProbe result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridPointProbe.vtkCellGridPointProbe_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridPointProbe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E046 RID: 57414 RVA: 0x00137128 File Offset: 0x00135328
		public vtkCellGridPointProbe() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridPointProbe.vtkCellGridPointProbe_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E047 RID: 57415 RVA: 0x0013716C File Offset: 0x0013536C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E048 RID: 57416
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridPointProbe_GetAttributeName_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E049 RID: 57417 RVA: 0x00137178 File Offset: 0x00135378
		public virtual string GetAttributeName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellGridPointProbe.vtkCellGridPointProbe_GetAttributeName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600E04A RID: 57418
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridPointProbe_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E04B RID: 57419 RVA: 0x001371B4 File Offset: 0x001353B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridPointProbe.vtkCellGridPointProbe_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E04C RID: 57420
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridPointProbe_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E04D RID: 57421 RVA: 0x001371D4 File Offset: 0x001353D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridPointProbe.vtkCellGridPointProbe_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E04E RID: 57422
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridPointProbe_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E04F RID: 57423 RVA: 0x001371F0 File Offset: 0x001353F0
		public override int IsA(string type)
		{
			return vtkCellGridPointProbe.vtkCellGridPointProbe_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E050 RID: 57424
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridPointProbe_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E051 RID: 57425 RVA: 0x00137210 File Offset: 0x00135410
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridPointProbe.vtkCellGridPointProbe_IsTypeOf_05(type);
		}

		// Token: 0x0600E052 RID: 57426
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridPointProbe_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E053 RID: 57427 RVA: 0x0013722C File Offset: 0x0013542C
		public new vtkCellGridPointProbe NewInstance()
		{
			vtkCellGridPointProbe result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridPointProbe.vtkCellGridPointProbe_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridPointProbe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E054 RID: 57428
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridPointProbe_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E055 RID: 57429 RVA: 0x00137288 File Offset: 0x00135488
		public new static vtkCellGridPointProbe SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridPointProbe vtkCellGridPointProbe = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridPointProbe.vtkCellGridPointProbe_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridPointProbe = (vtkCellGridPointProbe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridPointProbe.Register(null);
				}
			}
			return vtkCellGridPointProbe;
		}

		// Token: 0x0600E056 RID: 57430
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridPointProbe_SetAttributeName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E057 RID: 57431 RVA: 0x00137307 File Offset: 0x00135507
		public virtual void SetAttributeName(string _arg)
		{
			vtkCellGridPointProbe.vtkCellGridPointProbe_SetAttributeName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001077 RID: 4215
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridPointProbe";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001078 RID: 4216
		public new static readonly string MRClassNameKey = "class vtkCellGridPointProbe";
	}
}
