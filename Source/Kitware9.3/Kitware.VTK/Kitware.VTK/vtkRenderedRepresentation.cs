using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderedRepresentation
	///
	///
	/// </summary>
	// Token: 0x02000079 RID: 121
	public class vtkRenderedRepresentation : vtkDataRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060016A2 RID: 5794 RVA: 0x00025E7C File Offset: 0x0002407C
		static vtkRenderedRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060016A3 RID: 5795 RVA: 0x00025EA4 File Offset: 0x000240A4
		public vtkRenderedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060016A4 RID: 5796
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016A5 RID: 5797 RVA: 0x00025EB4 File Offset: 0x000240B4
		public new static vtkRenderedRepresentation New()
		{
			vtkRenderedRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedRepresentation.vtkRenderedRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016A6 RID: 5798 RVA: 0x00025F08 File Offset: 0x00024108
		public vtkRenderedRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderedRepresentation.vtkRenderedRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060016A7 RID: 5799 RVA: 0x00025F4C File Offset: 0x0002414C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060016A8 RID: 5800
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedRepresentation_GetLabelRenderMode_01(HandleRef pThis);

		/// <summary>
		/// Set the label render mode.
		/// vtkRenderView::QT - Use Qt-based labeler with fitted labeling
		/// and unicode support. Requires VTK_USE_QT to be on.
		/// vtkRenderView::FREETYPE - Use standard freetype text rendering.
		/// </summary>
		// Token: 0x060016A9 RID: 5801 RVA: 0x00025F58 File Offset: 0x00024158
		public virtual int GetLabelRenderMode()
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_GetLabelRenderMode_01(base.GetCppThis());
		}

		// Token: 0x060016AA RID: 5802
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016AB RID: 5803 RVA: 0x00025F78 File Offset: 0x00024178
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060016AC RID: 5804
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedRepresentation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016AD RID: 5805 RVA: 0x00025F98 File Offset: 0x00024198
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060016AE RID: 5806
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedRepresentation_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016AF RID: 5807 RVA: 0x00025FB4 File Offset: 0x000241B4
		public override int IsA(string type)
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060016B0 RID: 5808
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedRepresentation_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016B1 RID: 5809 RVA: 0x00025FD4 File Offset: 0x000241D4
		public new static int IsTypeOf(string type)
		{
			return vtkRenderedRepresentation.vtkRenderedRepresentation_IsTypeOf_05(type);
		}

		// Token: 0x060016B2 RID: 5810
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016B3 RID: 5811 RVA: 0x00025FF0 File Offset: 0x000241F0
		public new vtkRenderedRepresentation NewInstance()
		{
			vtkRenderedRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedRepresentation.vtkRenderedRepresentation_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060016B4 RID: 5812
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedRepresentation_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060016B5 RID: 5813 RVA: 0x0002604C File Offset: 0x0002424C
		public new static vtkRenderedRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedRepresentation vtkRenderedRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedRepresentation.vtkRenderedRepresentation_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedRepresentation = (vtkRenderedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedRepresentation.Register(null);
				}
			}
			return vtkRenderedRepresentation;
		}

		// Token: 0x060016B6 RID: 5814
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedRepresentation_SetLabelRenderMode_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the label render mode.
		/// vtkRenderView::QT - Use Qt-based labeler with fitted labeling
		/// and unicode support. Requires VTK_USE_QT to be on.
		/// vtkRenderView::FREETYPE - Use standard freetype text rendering.
		/// </summary>
		// Token: 0x060016B7 RID: 5815 RVA: 0x000260CB File Offset: 0x000242CB
		public virtual void SetLabelRenderMode(int _arg)
		{
			vtkRenderedRepresentation.vtkRenderedRepresentation_SetLabelRenderMode_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000484 RID: 1156
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000485 RID: 1157
		public new static readonly string MRClassNameKey = "class vtkRenderedRepresentation";
	}
}
