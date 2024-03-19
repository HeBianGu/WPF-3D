using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleRubberBandPick
	/// </summary>
	/// <remarks>
	///    Like TrackBallCamera, but this can pick props underneath a rubber band selection
	/// rectangle.
	///
	///
	/// This interactor style allows the user to draw a rectangle in the render
	/// window by hitting 'r' and then using the left mouse button.
	/// When the mouse button is released, the attached picker operates on the pixel
	/// in the center of the selection rectangle. If the picker happens to be a
	/// vtkAreaPicker it will operate on the entire selection rectangle.
	/// When the 'p' key is hit the above pick operation occurs on a 1x1 rectangle.
	/// In other respects it behaves the same as its parent class.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAreaPicker
	/// </seealso>
	// Token: 0x02000400 RID: 1024
	public class vtkInteractorStyleRubberBandPick : vtkInteractorStyleTrackballCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C30D RID: 49933 RVA: 0x0010F69F File Offset: 0x0010D89F
		static vtkInteractorStyleRubberBandPick()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBandPick.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBandPick"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C30E RID: 49934 RVA: 0x0010F6C7 File Offset: 0x0010D8C7
		public vtkInteractorStyleRubberBandPick(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C30F RID: 49935
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBandPick_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C310 RID: 49936 RVA: 0x0010F6D8 File Offset: 0x0010D8D8
		public new static vtkInteractorStyleRubberBandPick New()
		{
			vtkInteractorStyleRubberBandPick result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C311 RID: 49937 RVA: 0x0010F72C File Offset: 0x0010D92C
		public vtkInteractorStyleRubberBandPick() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C312 RID: 49938 RVA: 0x0010F770 File Offset: 0x0010D970
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C313 RID: 49939
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C314 RID: 49940 RVA: 0x0010F77C File Offset: 0x0010D97C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C315 RID: 49941
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C316 RID: 49942 RVA: 0x0010F79C File Offset: 0x0010D99C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C317 RID: 49943
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBandPick_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C318 RID: 49944 RVA: 0x0010F7B8 File Offset: 0x0010D9B8
		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C319 RID: 49945
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBandPick_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C31A RID: 49946 RVA: 0x0010F7D8 File Offset: 0x0010D9D8
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_IsTypeOf_04(type);
		}

		// Token: 0x0600C31B RID: 49947
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBandPick_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C31C RID: 49948 RVA: 0x0010F7F4 File Offset: 0x0010D9F4
		public new vtkInteractorStyleRubberBandPick NewInstance()
		{
			vtkInteractorStyleRubberBandPick result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C31D RID: 49949
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandPick_OnChar_07(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C31E RID: 49950 RVA: 0x0010F84E File Offset: 0x0010DA4E
		public override void OnChar()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnChar_07(base.GetCppThis());
		}

		// Token: 0x0600C31F RID: 49951
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandPick_OnLeftButtonDown_08(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C320 RID: 49952 RVA: 0x0010F85D File Offset: 0x0010DA5D
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnLeftButtonDown_08(base.GetCppThis());
		}

		// Token: 0x0600C321 RID: 49953
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandPick_OnLeftButtonUp_09(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C322 RID: 49954 RVA: 0x0010F86C File Offset: 0x0010DA6C
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnLeftButtonUp_09(base.GetCppThis());
		}

		// Token: 0x0600C323 RID: 49955
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandPick_OnMouseMove_10(HandleRef pThis);

		/// <summary>
		/// Event bindings
		/// </summary>
		// Token: 0x0600C324 RID: 49956 RVA: 0x0010F87B File Offset: 0x0010DA7B
		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_OnMouseMove_10(base.GetCppThis());
		}

		// Token: 0x0600C325 RID: 49957
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBandPick_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C326 RID: 49958 RVA: 0x0010F88C File Offset: 0x0010DA8C
		public new static vtkInteractorStyleRubberBandPick SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBandPick vtkInteractorStyleRubberBandPick = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBandPick = (vtkInteractorStyleRubberBandPick)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBandPick.Register(null);
				}
			}
			return vtkInteractorStyleRubberBandPick;
		}

		// Token: 0x0600C327 RID: 49959
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBandPick_StartSelect_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C328 RID: 49960 RVA: 0x0010F90B File Offset: 0x0010DB0B
		public void StartSelect()
		{
			vtkInteractorStyleRubberBandPick.vtkInteractorStyleRubberBandPick_StartSelect_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E72 RID: 3698
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBandPick";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E73 RID: 3699
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleRubberBandPick";
	}
}
