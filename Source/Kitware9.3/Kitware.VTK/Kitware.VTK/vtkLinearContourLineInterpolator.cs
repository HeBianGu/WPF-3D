using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Interpolates supplied nodes with line segments
	///
	/// The line interpolator interpolates supplied nodes (see InterpolateLine)
	/// with line segments. The fineness of the curve may be controlled using
	/// SetMaximumCurveError and SetMaximumNumberOfLineSegments.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourLineInterpolator
	/// </seealso>
	// Token: 0x02000335 RID: 821
	public class vtkLinearContourLineInterpolator : vtkContourLineInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600950D RID: 38157 RVA: 0x000D30EB File Offset: 0x000D12EB
		static vtkLinearContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600950E RID: 38158 RVA: 0x000D3113 File Offset: 0x000D1313
		public vtkLinearContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600950F RID: 38159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009510 RID: 38160 RVA: 0x000D3124 File Offset: 0x000D1324
		public new static vtkLinearContourLineInterpolator New()
		{
			vtkLinearContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009511 RID: 38161 RVA: 0x000D3178 File Offset: 0x000D1378
		public vtkLinearContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009512 RID: 38162 RVA: 0x000D31BC File Offset: 0x000D13BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009513 RID: 38163
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearContourLineInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009514 RID: 38164 RVA: 0x000D31C8 File Offset: 0x000D13C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06009515 RID: 38165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009516 RID: 38166 RVA: 0x000D31E8 File Offset: 0x000D13E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06009517 RID: 38167
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearContourLineInterpolator_InterpolateLine_03(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009518 RID: 38168 RVA: 0x000D3204 File Offset: 0x000D1404
		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_InterpolateLine_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x06009519 RID: 38169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearContourLineInterpolator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600951A RID: 38170 RVA: 0x000D3250 File Offset: 0x000D1450
		public override int IsA(string type)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600951B RID: 38171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearContourLineInterpolator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600951C RID: 38172 RVA: 0x000D3270 File Offset: 0x000D1470
		public new static int IsTypeOf(string type)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_IsTypeOf_05(type);
		}

		// Token: 0x0600951D RID: 38173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600951E RID: 38174 RVA: 0x000D328C File Offset: 0x000D148C
		public new vtkLinearContourLineInterpolator NewInstance()
		{
			vtkLinearContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600951F RID: 38175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009520 RID: 38176 RVA: 0x000D32E8 File Offset: 0x000D14E8
		public new static vtkLinearContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkLinearContourLineInterpolator vtkLinearContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearContourLineInterpolator = (vtkLinearContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearContourLineInterpolator.Register(null);
				}
			}
			return vtkLinearContourLineInterpolator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C3D RID: 3133
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C3E RID: 3134
		public new static readonly string MRClassNameKey = "class vtkLinearContourLineInterpolator";
	}
}
