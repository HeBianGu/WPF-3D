using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphToPoints
	/// </summary>
	/// <remarks>
	///    convert a vtkGraph a set of points.
	///
	///
	/// Converts a vtkGraph to a vtkPolyData containing a set of points.
	/// This assumes that the points
	/// of the graph have already been filled (perhaps by vtkGraphLayout).
	/// The vertex data is passed along to the point data.
	/// </remarks>
	// Token: 0x020008A4 RID: 2212
	public class vtkGraphToPoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016F49 RID: 94025 RVA: 0x00203FF5 File Offset: 0x002021F5
		static vtkGraphToPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphToPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016F4A RID: 94026 RVA: 0x0020401D File Offset: 0x0020221D
		public vtkGraphToPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016F4B RID: 94027
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F4C RID: 94028 RVA: 0x0020402C File Offset: 0x0020222C
		public new static vtkGraphToPoints New()
		{
			vtkGraphToPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToPoints.vtkGraphToPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F4D RID: 94029 RVA: 0x00204080 File Offset: 0x00202280
		public vtkGraphToPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphToPoints.vtkGraphToPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016F4E RID: 94030 RVA: 0x002040C4 File Offset: 0x002022C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016F4F RID: 94031
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphToPoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F50 RID: 94032 RVA: 0x002040D0 File Offset: 0x002022D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphToPoints.vtkGraphToPoints_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016F51 RID: 94033
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphToPoints_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F52 RID: 94034 RVA: 0x002040F0 File Offset: 0x002022F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphToPoints.vtkGraphToPoints_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016F53 RID: 94035
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToPoints_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F54 RID: 94036 RVA: 0x0020410C File Offset: 0x0020230C
		public override int IsA(string type)
		{
			return vtkGraphToPoints.vtkGraphToPoints_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016F55 RID: 94037
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToPoints_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F56 RID: 94038 RVA: 0x0020412C File Offset: 0x0020232C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphToPoints.vtkGraphToPoints_IsTypeOf_04(type);
		}

		// Token: 0x06016F57 RID: 94039
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToPoints_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F58 RID: 94040 RVA: 0x00204148 File Offset: 0x00202348
		public new vtkGraphToPoints NewInstance()
		{
			vtkGraphToPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToPoints.vtkGraphToPoints_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016F59 RID: 94041
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToPoints_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F5A RID: 94042 RVA: 0x002041A4 File Offset: 0x002023A4
		public new static vtkGraphToPoints SafeDownCast(vtkObjectBase o)
		{
			vtkGraphToPoints vtkGraphToPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToPoints.vtkGraphToPoints_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphToPoints = (vtkGraphToPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphToPoints.Register(null);
				}
			}
			return vtkGraphToPoints;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019AE RID: 6574
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019AF RID: 6575
		public new static readonly string MRClassNameKey = "class vtkGraphToPoints";
	}
}
