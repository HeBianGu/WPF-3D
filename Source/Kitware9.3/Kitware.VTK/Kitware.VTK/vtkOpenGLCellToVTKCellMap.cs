using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLCellToVTKCellMap
	/// </summary>
	/// <remarks>
	///    OpenGL rendering utility functions
	///
	/// vtkOpenGLCellToVTKCellMap provides functions map from opengl primitive ID to vtk
	///
	///
	/// </remarks>
	// Token: 0x020005A2 RID: 1442
	public class vtkOpenGLCellToVTKCellMap : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FCDD RID: 64733 RVA: 0x00160577 File Offset: 0x0015E777
		static vtkOpenGLCellToVTKCellMap()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLCellToVTKCellMap.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLCellToVTKCellMap"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCDE RID: 64734 RVA: 0x0016059F File Offset: 0x0015E79F
		public vtkOpenGLCellToVTKCellMap(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FCDF RID: 64735
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellToVTKCellMap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCE0 RID: 64736 RVA: 0x001605B0 File Offset: 0x0015E7B0
		public new static vtkOpenGLCellToVTKCellMap New()
		{
			vtkOpenGLCellToVTKCellMap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCellToVTKCellMap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCE1 RID: 64737 RVA: 0x00160604 File Offset: 0x0015E804
		public vtkOpenGLCellToVTKCellMap() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FCE2 RID: 64738 RVA: 0x00160648 File Offset: 0x0015E848
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FCE3 RID: 64739
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellToVTKCellMap_ConvertOpenGLCellIdToVTKCellId_01(HandleRef pThis, byte pointPicking, long openGLId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCE4 RID: 64740 RVA: 0x00160654 File Offset: 0x0015E854
		public long ConvertOpenGLCellIdToVTKCellId(bool pointPicking, long openGLId)
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_ConvertOpenGLCellIdToVTKCellId_01(base.GetCppThis(), pointPicking ? (byte)1 : (byte)0, openGLId);
		}

		// Token: 0x0600FCE5 RID: 64741
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellToVTKCellMap_GetFinalOffset_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCE6 RID: 64742 RVA: 0x00160680 File Offset: 0x0015E880
		public long GetFinalOffset()
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_GetFinalOffset_02(base.GetCppThis());
		}

		// Token: 0x0600FCE7 RID: 64743
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCE8 RID: 64744 RVA: 0x001606A0 File Offset: 0x0015E8A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FCE9 RID: 64745
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCEA RID: 64746 RVA: 0x001606C0 File Offset: 0x0015E8C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600FCEB RID: 64747
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellToVTKCellMap_GetPrimitiveOffsets_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCEC RID: 64748 RVA: 0x001606DC File Offset: 0x0015E8DC
		public IntPtr GetPrimitiveOffsets()
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_GetPrimitiveOffsets_05(base.GetCppThis());
		}

		// Token: 0x0600FCED RID: 64749
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLCellToVTKCellMap_GetSize_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCEE RID: 64750 RVA: 0x001606FC File Offset: 0x0015E8FC
		public ulong GetSize()
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_GetSize_06(base.GetCppThis());
		}

		// Token: 0x0600FCEF RID: 64751
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCellToVTKCellMap_GetValue_07(HandleRef pThis, ulong i);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCF0 RID: 64752 RVA: 0x0016071C File Offset: 0x0015E91C
		public long GetValue(ulong i)
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_GetValue_07(base.GetCppThis(), i);
		}

		// Token: 0x0600FCF1 RID: 64753
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCellToVTKCellMap_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCF2 RID: 64754 RVA: 0x0016073C File Offset: 0x0015E93C
		public override int IsA(string type)
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600FCF3 RID: 64755
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCellToVTKCellMap_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCF4 RID: 64756 RVA: 0x0016075C File Offset: 0x0015E95C
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_IsTypeOf_09(type);
		}

		// Token: 0x0600FCF5 RID: 64757
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellToVTKCellMap_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCF6 RID: 64758 RVA: 0x00160778 File Offset: 0x0015E978
		public new vtkOpenGLCellToVTKCellMap NewInstance()
		{
			vtkOpenGLCellToVTKCellMap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCellToVTKCellMap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FCF7 RID: 64759
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCellToVTKCellMap_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCF8 RID: 64760 RVA: 0x001607D4 File Offset: 0x0015E9D4
		public new static vtkOpenGLCellToVTKCellMap SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLCellToVTKCellMap vtkOpenGLCellToVTKCellMap = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLCellToVTKCellMap = (vtkOpenGLCellToVTKCellMap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLCellToVTKCellMap.Register(null);
				}
			}
			return vtkOpenGLCellToVTKCellMap;
		}

		// Token: 0x0600FCF9 RID: 64761
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCellToVTKCellMap_SetStartOffset_13(HandleRef pThis, long start);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FCFA RID: 64762 RVA: 0x00160853 File Offset: 0x0015EA53
		public void SetStartOffset(long start)
		{
			vtkOpenGLCellToVTKCellMap.vtkOpenGLCellToVTKCellMap_SetStartOffset_13(base.GetCppThis(), start);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400126F RID: 4719
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLCellToVTKCellMap";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001270 RID: 4720
		public new static readonly string MRClassNameKey = "class vtkOpenGLCellToVTKCellMap";
	}
}
