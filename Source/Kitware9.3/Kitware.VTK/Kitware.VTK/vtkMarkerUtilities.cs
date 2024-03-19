using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMarkerUtilities
	/// </summary>
	/// <remarks>
	///    Utilities for generating marker images
	///
	///
	/// This class programmatically generates markers of a specified size
	/// for various marker styles.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPlotLine, vtkPlotPoints
	/// </seealso>
	// Token: 0x020007B5 RID: 1973
	public class vtkMarkerUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014435 RID: 82997 RVA: 0x001CA403 File Offset: 0x001C8603
		static vtkMarkerUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarkerUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarkerUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014436 RID: 82998 RVA: 0x001CA42B File Offset: 0x001C862B
		public vtkMarkerUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014437 RID: 82999 RVA: 0x001CA439 File Offset: 0x001C8639
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014438 RID: 83000
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarkerUtilities_GenerateMarker_01(HandleRef data, int style, int width);

		/// <summary>
		/// Generate the requested symbol of a particular style and size.
		/// </summary>
		// Token: 0x06014439 RID: 83001 RVA: 0x001CA444 File Offset: 0x001C8644
		public static void GenerateMarker(vtkImageData data, int style, int width)
		{
			vtkMarkerUtilities.vtkMarkerUtilities_GenerateMarker_01((data == null) ? default(HandleRef) : data.GetCppThis(), style, width);
		}

		// Token: 0x0601443A RID: 83002
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarkerUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601443B RID: 83003 RVA: 0x001CA470 File Offset: 0x001C8670
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMarkerUtilities.vtkMarkerUtilities_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601443C RID: 83004
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarkerUtilities_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601443D RID: 83005 RVA: 0x001CA490 File Offset: 0x001C8690
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMarkerUtilities.vtkMarkerUtilities_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601443E RID: 83006
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarkerUtilities_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601443F RID: 83007 RVA: 0x001CA4AC File Offset: 0x001C86AC
		public override int IsA(string type)
		{
			return vtkMarkerUtilities.vtkMarkerUtilities_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06014440 RID: 83008
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarkerUtilities_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014441 RID: 83009 RVA: 0x001CA4CC File Offset: 0x001C86CC
		public new static int IsTypeOf(string type)
		{
			return vtkMarkerUtilities.vtkMarkerUtilities_IsTypeOf_05(type);
		}

		// Token: 0x06014442 RID: 83010
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkerUtilities_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014443 RID: 83011 RVA: 0x001CA4E8 File Offset: 0x001C86E8
		public new vtkMarkerUtilities NewInstance()
		{
			vtkMarkerUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarkerUtilities.vtkMarkerUtilities_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarkerUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014444 RID: 83012
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarkerUtilities_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014445 RID: 83013 RVA: 0x001CA544 File Offset: 0x001C8744
		public new static vtkMarkerUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkMarkerUtilities vtkMarkerUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarkerUtilities.vtkMarkerUtilities_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarkerUtilities = (vtkMarkerUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarkerUtilities.Register(null);
				}
			}
			return vtkMarkerUtilities;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001779 RID: 6009
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarkerUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400177A RID: 6010
		public new static readonly string MRClassNameKey = "class vtkMarkerUtilities";

		/// <summary>
		/// Enum containing various marker styles that can be used in a plot.
		/// </summary>
		// Token: 0x020007B6 RID: 1974
		public enum CIRCLE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400177C RID: 6012
			CIRCLE = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400177D RID: 6013
			CROSS = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400177E RID: 6014
			DIAMOND = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400177F RID: 6015
			NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001780 RID: 6016
			PLUS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001781 RID: 6017
			SQUARE
		}
	}
}
