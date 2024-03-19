using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractPointCloudPiece
	/// </summary>
	/// <remarks>
	///    Return a piece of a point cloud
	///
	/// This filter takes the output of a vtkHierarchicalBinningFilter and allows
	/// the pipeline to stream it. Pieces are determined from an offset integral
	/// array associated with the field data of the input.
	/// </remarks>
	// Token: 0x02000441 RID: 1089
	public class vtkExtractPointCloudPiece : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CB73 RID: 52083 RVA: 0x0011AFF3 File Offset: 0x001191F3
		static vtkExtractPointCloudPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractPointCloudPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractPointCloudPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB74 RID: 52084 RVA: 0x0011B01B File Offset: 0x0011921B
		public vtkExtractPointCloudPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CB75 RID: 52085
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPointCloudPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB76 RID: 52086 RVA: 0x0011B02C File Offset: 0x0011922C
		public new static vtkExtractPointCloudPiece New()
		{
			vtkExtractPointCloudPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPointCloudPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB77 RID: 52087 RVA: 0x0011B080 File Offset: 0x00119280
		public vtkExtractPointCloudPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB78 RID: 52088 RVA: 0x0011B0C4 File Offset: 0x001192C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CB79 RID: 52089
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractPointCloudPiece_GetModuloOrdering_01(HandleRef pThis);

		/// <summary>
		/// Turn on or off modulo sampling of the points. By default this is on and the
		/// points in a given piece will be reordered in an attempt to reduce spatial
		/// coherency.
		/// </summary>
		// Token: 0x0600CB7A RID: 52090 RVA: 0x0011B0D0 File Offset: 0x001192D0
		public virtual bool GetModuloOrdering()
		{
			return vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_GetModuloOrdering_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CB7B RID: 52091
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB7C RID: 52092 RVA: 0x0011B0F8 File Offset: 0x001192F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CB7D RID: 52093
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB7E RID: 52094 RVA: 0x0011B118 File Offset: 0x00119318
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CB7F RID: 52095
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPointCloudPiece_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB80 RID: 52096 RVA: 0x0011B134 File Offset: 0x00119334
		public override int IsA(string type)
		{
			return vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CB81 RID: 52097
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractPointCloudPiece_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB82 RID: 52098 RVA: 0x0011B154 File Offset: 0x00119354
		public new static int IsTypeOf(string type)
		{
			return vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_IsTypeOf_05(type);
		}

		// Token: 0x0600CB83 RID: 52099
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPointCloudPiece_ModuloOrderingOff_06(HandleRef pThis);

		/// <summary>
		/// Turn on or off modulo sampling of the points. By default this is on and the
		/// points in a given piece will be reordered in an attempt to reduce spatial
		/// coherency.
		/// </summary>
		// Token: 0x0600CB84 RID: 52100 RVA: 0x0011B16E File Offset: 0x0011936E
		public virtual void ModuloOrderingOff()
		{
			vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_ModuloOrderingOff_06(base.GetCppThis());
		}

		// Token: 0x0600CB85 RID: 52101
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPointCloudPiece_ModuloOrderingOn_07(HandleRef pThis);

		/// <summary>
		/// Turn on or off modulo sampling of the points. By default this is on and the
		/// points in a given piece will be reordered in an attempt to reduce spatial
		/// coherency.
		/// </summary>
		// Token: 0x0600CB86 RID: 52102 RVA: 0x0011B17D File Offset: 0x0011937D
		public virtual void ModuloOrderingOn()
		{
			vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_ModuloOrderingOn_07(base.GetCppThis());
		}

		// Token: 0x0600CB87 RID: 52103
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPointCloudPiece_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB88 RID: 52104 RVA: 0x0011B18C File Offset: 0x0011938C
		public new vtkExtractPointCloudPiece NewInstance()
		{
			vtkExtractPointCloudPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractPointCloudPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CB89 RID: 52105
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractPointCloudPiece_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, printing, and type information.
		/// </summary>
		// Token: 0x0600CB8A RID: 52106 RVA: 0x0011B1E8 File Offset: 0x001193E8
		public new static vtkExtractPointCloudPiece SafeDownCast(vtkObjectBase o)
		{
			vtkExtractPointCloudPiece vtkExtractPointCloudPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractPointCloudPiece = (vtkExtractPointCloudPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractPointCloudPiece.Register(null);
				}
			}
			return vtkExtractPointCloudPiece;
		}

		// Token: 0x0600CB8B RID: 52107
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractPointCloudPiece_SetModuloOrdering_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on or off modulo sampling of the points. By default this is on and the
		/// points in a given piece will be reordered in an attempt to reduce spatial
		/// coherency.
		/// </summary>
		// Token: 0x0600CB8C RID: 52108 RVA: 0x0011B267 File Offset: 0x00119467
		public virtual void SetModuloOrdering(bool _arg)
		{
			vtkExtractPointCloudPiece.vtkExtractPointCloudPiece_SetModuloOrdering_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F0F RID: 3855
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractPointCloudPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F10 RID: 3856
		public new static readonly string MRClassNameKey = "class vtkExtractPointCloudPiece";
	}
}
