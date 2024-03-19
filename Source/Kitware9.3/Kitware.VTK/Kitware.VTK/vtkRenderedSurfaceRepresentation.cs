using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderedSurfaceRepresentation
	/// </summary>
	/// <remarks>
	///    Displays a geometric dataset as a surface.
	///
	///
	/// vtkRenderedSurfaceRepresentation is used to show a geometric dataset in a view.
	/// The representation uses a vtkGeometryFilter to convert the dataset to
	/// polygonal data (e.g. volumetric data is converted to its external surface).
	/// The representation may then be added to vtkRenderView.
	/// </remarks>
	// Token: 0x02000083 RID: 131
	public class vtkRenderedSurfaceRepresentation : vtkRenderedRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001946 RID: 6470 RVA: 0x00028B6E File Offset: 0x00026D6E
		static vtkRenderedSurfaceRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedSurfaceRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedSurfaceRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001947 RID: 6471 RVA: 0x00028B96 File Offset: 0x00026D96
		public vtkRenderedSurfaceRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001948 RID: 6472
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001949 RID: 6473 RVA: 0x00028BA4 File Offset: 0x00026DA4
		public new static vtkRenderedSurfaceRepresentation New()
		{
			vtkRenderedSurfaceRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedSurfaceRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600194A RID: 6474 RVA: 0x00028BF8 File Offset: 0x00026DF8
		public vtkRenderedSurfaceRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600194B RID: 6475 RVA: 0x00028C3C File Offset: 0x00026E3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600194C RID: 6476
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedSurfaceRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Apply a theme to this representation.
		/// </summary>
		// Token: 0x0600194D RID: 6477 RVA: 0x00028C48 File Offset: 0x00026E48
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x0600194E RID: 6478
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_GetCellColorArrayName_02(HandleRef pThis);

		/// <summary>
		/// Sets the color array name
		/// </summary>
		// Token: 0x0600194F RID: 6479 RVA: 0x00028C78 File Offset: 0x00026E78
		public virtual string GetCellColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_GetCellColorArrayName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001950 RID: 6480
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedSurfaceRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001951 RID: 6481 RVA: 0x00028CB4 File Offset: 0x00026EB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06001952 RID: 6482
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedSurfaceRepresentation_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001953 RID: 6483 RVA: 0x00028CD4 File Offset: 0x00026ED4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06001954 RID: 6484
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedSurfaceRepresentation_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001955 RID: 6485 RVA: 0x00028CF0 File Offset: 0x00026EF0
		public override int IsA(string type)
		{
			return vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06001956 RID: 6486
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedSurfaceRepresentation_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001957 RID: 6487 RVA: 0x00028D10 File Offset: 0x00026F10
		public new static int IsTypeOf(string type)
		{
			return vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_IsTypeOf_06(type);
		}

		// Token: 0x06001958 RID: 6488
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001959 RID: 6489 RVA: 0x00028D2C File Offset: 0x00026F2C
		public new vtkRenderedSurfaceRepresentation NewInstance()
		{
			vtkRenderedSurfaceRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedSurfaceRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600195A RID: 6490
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedSurfaceRepresentation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600195B RID: 6491 RVA: 0x00028D88 File Offset: 0x00026F88
		public new static vtkRenderedSurfaceRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedSurfaceRepresentation vtkRenderedSurfaceRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedSurfaceRepresentation = (vtkRenderedSurfaceRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedSurfaceRepresentation.Register(null);
				}
			}
			return vtkRenderedSurfaceRepresentation;
		}

		// Token: 0x0600195C RID: 6492
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedSurfaceRepresentation_SetCellColorArrayName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// Sets the color array name
		/// </summary>
		// Token: 0x0600195D RID: 6493 RVA: 0x00028E07 File Offset: 0x00027007
		public virtual void SetCellColorArrayName(string arrayName)
		{
			vtkRenderedSurfaceRepresentation.vtkRenderedSurfaceRepresentation_SetCellColorArrayName_10(base.GetCppThis(), arrayName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A4 RID: 1188
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedSurfaceRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A5 RID: 1189
		public new static readonly string MRClassNameKey = "class vtkRenderedSurfaceRepresentation";
	}
}
