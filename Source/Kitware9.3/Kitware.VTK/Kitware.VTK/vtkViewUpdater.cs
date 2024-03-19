using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkViewUpdater
	/// </summary>
	/// <remarks>
	///    Updates views automatically
	///
	///
	/// vtkViewUpdater registers with annotation change events for a set of
	/// annotation links, and updates all views when an annotation link fires an
	/// annotation changed event. This is often needed when multiple views share
	/// a selection with vtkAnnotationLink.
	/// </remarks>
	// Token: 0x0200008B RID: 139
	public class vtkViewUpdater : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001B29 RID: 6953 RVA: 0x0002B390 File Offset: 0x00029590
		static vtkViewUpdater()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewUpdater.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewUpdater"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001B2A RID: 6954 RVA: 0x0002B3B8 File Offset: 0x000295B8
		public vtkViewUpdater(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001B2B RID: 6955
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewUpdater_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B2C RID: 6956 RVA: 0x0002B3C8 File Offset: 0x000295C8
		public new static vtkViewUpdater New()
		{
			vtkViewUpdater result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewUpdater.vtkViewUpdater_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewUpdater)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B2D RID: 6957 RVA: 0x0002B41C File Offset: 0x0002961C
		public vtkViewUpdater() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkViewUpdater.vtkViewUpdater_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001B2E RID: 6958 RVA: 0x0002B460 File Offset: 0x00029660
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001B2F RID: 6959
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewUpdater_AddAnnotationLink_01(HandleRef pThis, HandleRef link);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B30 RID: 6960 RVA: 0x0002B46C File Offset: 0x0002966C
		public void AddAnnotationLink(vtkAnnotationLink link)
		{
			vtkViewUpdater.vtkViewUpdater_AddAnnotationLink_01(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		// Token: 0x06001B31 RID: 6961
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewUpdater_AddView_02(HandleRef pThis, HandleRef view);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B32 RID: 6962 RVA: 0x0002B49C File Offset: 0x0002969C
		public void AddView(vtkView view)
		{
			vtkViewUpdater.vtkViewUpdater_AddView_02(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis());
		}

		// Token: 0x06001B33 RID: 6963
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewUpdater_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B34 RID: 6964 RVA: 0x0002B4CC File Offset: 0x000296CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkViewUpdater.vtkViewUpdater_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06001B35 RID: 6965
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewUpdater_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B36 RID: 6966 RVA: 0x0002B4EC File Offset: 0x000296EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkViewUpdater.vtkViewUpdater_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06001B37 RID: 6967
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewUpdater_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B38 RID: 6968 RVA: 0x0002B508 File Offset: 0x00029708
		public override int IsA(string type)
		{
			return vtkViewUpdater.vtkViewUpdater_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06001B39 RID: 6969
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewUpdater_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B3A RID: 6970 RVA: 0x0002B528 File Offset: 0x00029728
		public new static int IsTypeOf(string type)
		{
			return vtkViewUpdater.vtkViewUpdater_IsTypeOf_06(type);
		}

		// Token: 0x06001B3B RID: 6971
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewUpdater_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B3C RID: 6972 RVA: 0x0002B544 File Offset: 0x00029744
		public new vtkViewUpdater NewInstance()
		{
			vtkViewUpdater result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewUpdater.vtkViewUpdater_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewUpdater)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B3D RID: 6973
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewUpdater_RemoveView_09(HandleRef pThis, HandleRef view);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B3E RID: 6974 RVA: 0x0002B5A0 File Offset: 0x000297A0
		public void RemoveView(vtkView view)
		{
			vtkViewUpdater.vtkViewUpdater_RemoveView_09(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis());
		}

		// Token: 0x06001B3F RID: 6975
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewUpdater_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B40 RID: 6976 RVA: 0x0002B5D0 File Offset: 0x000297D0
		public new static vtkViewUpdater SafeDownCast(vtkObjectBase o)
		{
			vtkViewUpdater vtkViewUpdater = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewUpdater.vtkViewUpdater_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewUpdater = (vtkViewUpdater)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewUpdater.Register(null);
				}
			}
			return vtkViewUpdater;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B4 RID: 1204
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewUpdater";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B5 RID: 1205
		public new static readonly string MRClassNameKey = "class vtkViewUpdater";
	}
}
