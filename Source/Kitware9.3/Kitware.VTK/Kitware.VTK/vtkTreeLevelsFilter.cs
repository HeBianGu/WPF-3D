using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeLevelsFilter
	/// </summary>
	/// <remarks>
	///    adds level and leaf fields to a vtkTree
	///
	///
	/// The filter currently add two arrays to the incoming vtkTree datastructure.
	/// 1) "levels" this is the distance from the root of the vertex. Root = 0
	/// and you add 1 for each level down from the root
	/// 2) "leaf" this array simply indicates whether the vertex is a leaf or not
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie from Sandia National Laboratories for creating this
	/// class.
	/// </remarks>
	// Token: 0x0200069F RID: 1695
	public class vtkTreeLevelsFilter : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601222D RID: 74285 RVA: 0x001965E3 File Offset: 0x001947E3
		static vtkTreeLevelsFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeLevelsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeLevelsFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601222E RID: 74286 RVA: 0x0019660B File Offset: 0x0019480B
		public vtkTreeLevelsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601222F RID: 74287
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLevelsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012230 RID: 74288 RVA: 0x0019661C File Offset: 0x0019481C
		public new static vtkTreeLevelsFilter New()
		{
			vtkTreeLevelsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeLevelsFilter.vtkTreeLevelsFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLevelsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012231 RID: 74289 RVA: 0x00196670 File Offset: 0x00194870
		public vtkTreeLevelsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeLevelsFilter.vtkTreeLevelsFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012232 RID: 74290 RVA: 0x001966B4 File Offset: 0x001948B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012233 RID: 74291
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeLevelsFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012234 RID: 74292 RVA: 0x001966C0 File Offset: 0x001948C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeLevelsFilter.vtkTreeLevelsFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012235 RID: 74293
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeLevelsFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012236 RID: 74294 RVA: 0x001966E0 File Offset: 0x001948E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeLevelsFilter.vtkTreeLevelsFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012237 RID: 74295
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeLevelsFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012238 RID: 74296 RVA: 0x001966FC File Offset: 0x001948FC
		public override int IsA(string type)
		{
			return vtkTreeLevelsFilter.vtkTreeLevelsFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012239 RID: 74297
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeLevelsFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601223A RID: 74298 RVA: 0x0019671C File Offset: 0x0019491C
		public new static int IsTypeOf(string type)
		{
			return vtkTreeLevelsFilter.vtkTreeLevelsFilter_IsTypeOf_04(type);
		}

		// Token: 0x0601223B RID: 74299
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLevelsFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601223C RID: 74300 RVA: 0x00196738 File Offset: 0x00194938
		public new vtkTreeLevelsFilter NewInstance()
		{
			vtkTreeLevelsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeLevelsFilter.vtkTreeLevelsFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLevelsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601223D RID: 74301
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLevelsFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601223E RID: 74302 RVA: 0x00196794 File Offset: 0x00194994
		public new static vtkTreeLevelsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTreeLevelsFilter vtkTreeLevelsFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeLevelsFilter.vtkTreeLevelsFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeLevelsFilter = (vtkTreeLevelsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeLevelsFilter.Register(null);
				}
			}
			return vtkTreeLevelsFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014EC RID: 5356
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeLevelsFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014ED RID: 5357
		public new static readonly string MRClassNameKey = "class vtkTreeLevelsFilter";
	}
}
