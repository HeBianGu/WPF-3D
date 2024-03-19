using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotLine3D
	/// </summary>
	/// <remarks>
	///    Class for drawing an XYZ line plot given three columns from
	/// a vtkTable.
	///
	///
	/// This class draws points with a line between them given three column from a
	/// vtkTable in a vtkChartXYZ.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlotPoints3D
	/// vtkPlotLine
	///
	/// </seealso>
	// Token: 0x02000666 RID: 1638
	public class vtkPlotLine3D : vtkPlotPoints3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011AC3 RID: 72387 RVA: 0x0018B3A7 File Offset: 0x001895A7
		static vtkPlotLine3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotLine3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotLine3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011AC4 RID: 72388 RVA: 0x0018B3CF File Offset: 0x001895CF
		public vtkPlotLine3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011AC5 RID: 72389
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotLine3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 3D Chart object.
		/// </summary>
		// Token: 0x06011AC6 RID: 72390 RVA: 0x0018B3E0 File Offset: 0x001895E0
		public new static vtkPlotLine3D New()
		{
			vtkPlotLine3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotLine3D.vtkPlotLine3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotLine3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 3D Chart object.
		/// </summary>
		// Token: 0x06011AC7 RID: 72391 RVA: 0x0018B434 File Offset: 0x00189634
		public vtkPlotLine3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotLine3D.vtkPlotLine3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011AC8 RID: 72392 RVA: 0x0018B478 File Offset: 0x00189678
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011AC9 RID: 72393
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotLine3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ACA RID: 72394 RVA: 0x0018B484 File Offset: 0x00189684
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotLine3D.vtkPlotLine3D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011ACB RID: 72395
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotLine3D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ACC RID: 72396 RVA: 0x0018B4A4 File Offset: 0x001896A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotLine3D.vtkPlotLine3D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011ACD RID: 72397
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotLine3D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ACE RID: 72398 RVA: 0x0018B4C0 File Offset: 0x001896C0
		public override int IsA(string type)
		{
			return vtkPlotLine3D.vtkPlotLine3D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06011ACF RID: 72399
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotLine3D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AD0 RID: 72400 RVA: 0x0018B4E0 File Offset: 0x001896E0
		public new static int IsTypeOf(string type)
		{
			return vtkPlotLine3D.vtkPlotLine3D_IsTypeOf_04(type);
		}

		// Token: 0x06011AD1 RID: 72401
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotLine3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AD2 RID: 72402 RVA: 0x0018B4FC File Offset: 0x001896FC
		public new vtkPlotLine3D NewInstance()
		{
			vtkPlotLine3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotLine3D.vtkPlotLine3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotLine3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011AD3 RID: 72403
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotLine3D_Paint_07(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the XYZ plot, called whenever the chart needs to be drawn.
		/// </summary>
		// Token: 0x06011AD4 RID: 72404 RVA: 0x0018B558 File Offset: 0x00189758
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotLine3D.vtkPlotLine3D_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011AD5 RID: 72405
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotLine3D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011AD6 RID: 72406 RVA: 0x0018B594 File Offset: 0x00189794
		public new static vtkPlotLine3D SafeDownCast(vtkObjectBase o)
		{
			vtkPlotLine3D vtkPlotLine3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotLine3D.vtkPlotLine3D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotLine3D = (vtkPlotLine3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotLine3D.Register(null);
				}
			}
			return vtkPlotLine3D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001465 RID: 5221
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotLine3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001466 RID: 5222
		public new static readonly string MRClassNameKey = "class vtkPlotLine3D";
	}
}
