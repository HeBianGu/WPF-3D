using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlaybackWidget
	/// </summary>
	/// <remarks>
	///    2D widget for controlling a playback stream
	///
	/// This class provides support for interactively controlling the playback of
	/// a serial stream of information (e.g., animation sequence, video, etc.).
	/// Controls for play, stop, advance one step forward, advance one step backward,
	/// jump to beginning, and jump to end are available.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget
	/// </seealso>
	// Token: 0x0200034E RID: 846
	public class vtkPlaybackWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060099FD RID: 39421 RVA: 0x000DA38E File Offset: 0x000D858E
		static vtkPlaybackWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaybackWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaybackWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060099FE RID: 39422 RVA: 0x000DA3B6 File Offset: 0x000D85B6
		public vtkPlaybackWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060099FF RID: 39423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009A00 RID: 39424 RVA: 0x000DA3C4 File Offset: 0x000D85C4
		public new static vtkPlaybackWidget New()
		{
			vtkPlaybackWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackWidget.vtkPlaybackWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009A01 RID: 39425 RVA: 0x000DA418 File Offset: 0x000D8618
		public vtkPlaybackWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlaybackWidget.vtkPlaybackWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009A02 RID: 39426 RVA: 0x000DA45C File Offset: 0x000D865C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009A03 RID: 39427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009A04 RID: 39428 RVA: 0x000DA467 File Offset: 0x000D8667
		public override void CreateDefaultRepresentation()
		{
			vtkPlaybackWidget.vtkPlaybackWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009A05 RID: 39429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaybackWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009A06 RID: 39430 RVA: 0x000DA478 File Offset: 0x000D8678
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlaybackWidget.vtkPlaybackWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009A07 RID: 39431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaybackWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009A08 RID: 39432 RVA: 0x000DA498 File Offset: 0x000D8698
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlaybackWidget.vtkPlaybackWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009A09 RID: 39433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009A0A RID: 39434 RVA: 0x000DA4B4 File Offset: 0x000D86B4
		public override int IsA(string type)
		{
			return vtkPlaybackWidget.vtkPlaybackWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06009A0B RID: 39435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaybackWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009A0C RID: 39436 RVA: 0x000DA4D4 File Offset: 0x000D86D4
		public new static int IsTypeOf(string type)
		{
			return vtkPlaybackWidget.vtkPlaybackWidget_IsTypeOf_05(type);
		}

		// Token: 0x06009A0D RID: 39437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009A0E RID: 39438 RVA: 0x000DA4F0 File Offset: 0x000D86F0
		public new vtkPlaybackWidget NewInstance()
		{
			vtkPlaybackWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackWidget.vtkPlaybackWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaybackWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009A0F RID: 39439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaybackWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009A10 RID: 39440 RVA: 0x000DA54C File Offset: 0x000D874C
		public new static vtkPlaybackWidget SafeDownCast(vtkObjectBase o)
		{
			vtkPlaybackWidget vtkPlaybackWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaybackWidget.vtkPlaybackWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaybackWidget = (vtkPlaybackWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaybackWidget.Register(null);
				}
			}
			return vtkPlaybackWidget;
		}

		// Token: 0x06009A11 RID: 39441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaybackWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkPlaybackRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009A12 RID: 39442 RVA: 0x000DA5CC File Offset: 0x000D87CC
		public void SetRepresentation(vtkPlaybackRepresentation r)
		{
			vtkPlaybackWidget.vtkPlaybackWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C8B RID: 3211
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaybackWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C8C RID: 3212
		public new static readonly string MRClassNameKey = "class vtkPlaybackWidget";
	}
}
