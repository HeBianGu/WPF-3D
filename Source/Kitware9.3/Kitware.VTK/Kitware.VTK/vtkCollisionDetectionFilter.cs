using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkCollisionDetectionFilter
	/// </summary>
	/// <remarks>
	///  performs collision determination between two polyhedral surfaces
	///
	/// vtkCollisionDetectionFilter performs collision determination between
	///  two polyhedral surfaces using two instances of vtkOBBTree. Set the
	///  polydata inputs, the tolerance and transforms or matrices. If
	///  CollisionMode is set to AllContacts, the Contacts output will be lines
	///  of contact.  If CollisionMode is FirstContact or HalfContacts then the
	///  Contacts output will be vertices.  See below for an explanation of
	///  these options.
	///
	///  This class can be used to clip one polydata surface with another,
	///  using the Contacts output as a loop set in vtkSelectPolyData
	///
	/// @authors Goodwin Lawlor, Bill Lorensen
	/// </remarks>
	// Token: 0x0200054B RID: 1355
	public class vtkCollisionDetectionFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F127 RID: 61735 RVA: 0x00150007 File Offset: 0x0014E207
		static vtkCollisionDetectionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollisionDetectionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollisionDetectionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F128 RID: 61736 RVA: 0x0015002F File Offset: 0x0014E22F
		public vtkCollisionDetectionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F129 RID: 61737
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F12A RID: 61738 RVA: 0x00150040 File Offset: 0x0014E240
		public new static vtkCollisionDetectionFilter New()
		{
			vtkCollisionDetectionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollisionDetectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F12B RID: 61739 RVA: 0x00150094 File Offset: 0x0014E294
		public vtkCollisionDetectionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F12C RID: 61740 RVA: 0x001500D8 File Offset: 0x0014E2D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F12D RID: 61741
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_GenerateScalarsOff_01(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F12E RID: 61742 RVA: 0x001500E3 File Offset: 0x0014E2E3
		public virtual void GenerateScalarsOff()
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GenerateScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x0600F12F RID: 61743
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_GenerateScalarsOn_02(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F130 RID: 61744 RVA: 0x001500F2 File Offset: 0x0014E2F2
		public virtual void GenerateScalarsOn()
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GenerateScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x0600F131 RID: 61745
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCollisionDetectionFilter_GetBoxTolerance_03(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F132 RID: 61746 RVA: 0x00150104 File Offset: 0x0014E304
		public virtual float GetBoxTolerance()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetBoxTolerance_03(base.GetCppThis());
		}

		// Token: 0x0600F133 RID: 61747
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCollisionDetectionFilter_GetCellTolerance_04(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F134 RID: 61748 RVA: 0x00150124 File Offset: 0x0014E324
		public virtual double GetCellTolerance()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetCellTolerance_04(base.GetCppThis());
		}

		// Token: 0x0600F135 RID: 61749
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetCollisionMode_05(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F136 RID: 61750 RVA: 0x00150144 File Offset: 0x0014E344
		public virtual int GetCollisionMode()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetCollisionMode_05(base.GetCppThis());
		}

		// Token: 0x0600F137 RID: 61751
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetCollisionModeAsString_06(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F138 RID: 61752 RVA: 0x00150164 File Offset: 0x0014E364
		public string GetCollisionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetCollisionModeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F139 RID: 61753
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetCollisionModeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F13A RID: 61754 RVA: 0x001501A0 File Offset: 0x0014E3A0
		public virtual int GetCollisionModeMaxValue()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetCollisionModeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600F13B RID: 61755
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetCollisionModeMinValue_08(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F13C RID: 61756 RVA: 0x001501C0 File Offset: 0x0014E3C0
		public virtual int GetCollisionModeMinValue()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetCollisionModeMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600F13D RID: 61757
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetContactCells_09(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// the "ContactCells" field array in outputs 0 and 1. These arrays index contacting
		/// cells (eg) index 50 of array 0 points to a cell (triangle) which contacts/intersects
		/// a cell at index 50 of array 1. This method is equivalent to
		/// GetOutput(i)-&gt;GetFieldData()-&gt;GetArray("ContactCells")
		/// </summary>
		// Token: 0x0600F13E RID: 61758 RVA: 0x001501E0 File Offset: 0x0014E3E0
		public vtkIdTypeArray GetContactCells(int i)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetContactCells_09(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0600F13F RID: 61759
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetContactsOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F140 RID: 61760 RVA: 0x00150250 File Offset: 0x0014E450
		public vtkPolyData GetContactsOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetContactsOutput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F141 RID: 61761
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetContactsOutputPort_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F142 RID: 61762 RVA: 0x001502C0 File Offset: 0x0014E4C0
		public vtkAlgorithmOutput GetContactsOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetContactsOutputPort_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600F143 RID: 61763
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetGenerateScalars_12(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F144 RID: 61764 RVA: 0x00150330 File Offset: 0x0014E530
		public virtual int GetGenerateScalars()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetGenerateScalars_12(base.GetCppThis());
		}

		// Token: 0x0600F145 RID: 61765
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetInputData_13(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and Get the input vtk polydata models
		/// </summary>
		// Token: 0x0600F146 RID: 61766 RVA: 0x00150350 File Offset: 0x0014E550
		public vtkPolyData GetInputData(int i)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetInputData_13(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F147 RID: 61767
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCollisionDetectionFilter_GetMTime_14(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F148 RID: 61768 RVA: 0x001503C0 File Offset: 0x0014E5C0
		public override ulong GetMTime()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x0600F149 RID: 61769
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetMatrix_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F14A RID: 61770 RVA: 0x001503E0 File Offset: 0x0014E5E0
		public vtkMatrix4x4 GetMatrix(int i)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetMatrix_15(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600F14B RID: 61771
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetNumberOfBoxTests_16(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F14C RID: 61772 RVA: 0x00150450 File Offset: 0x0014E650
		public virtual int GetNumberOfBoxTests()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetNumberOfBoxTests_16(base.GetCppThis());
		}

		// Token: 0x0600F14D RID: 61773
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetNumberOfCellsPerNode_17(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F14E RID: 61774 RVA: 0x00150470 File Offset: 0x0014E670
		public virtual int GetNumberOfCellsPerNode()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetNumberOfCellsPerNode_17(base.GetCppThis());
		}

		// Token: 0x0600F14F RID: 61775
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_GetNumberOfContacts_18(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F150 RID: 61776 RVA: 0x00150490 File Offset: 0x0014E690
		public int GetNumberOfContacts()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetNumberOfContacts_18(base.GetCppThis());
		}

		// Token: 0x0600F151 RID: 61777
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F152 RID: 61778 RVA: 0x001504B0 File Offset: 0x0014E6B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600F153 RID: 61779
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F154 RID: 61780 RVA: 0x001504D0 File Offset: 0x0014E6D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600F155 RID: 61781
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCollisionDetectionFilter_GetOpacity_21(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F156 RID: 61782 RVA: 0x001504EC File Offset: 0x0014E6EC
		public virtual float GetOpacity()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetOpacity_21(base.GetCppThis());
		}

		// Token: 0x0600F157 RID: 61783
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCollisionDetectionFilter_GetOpacityMaxValue_22(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F158 RID: 61784 RVA: 0x0015050C File Offset: 0x0014E70C
		public virtual float GetOpacityMaxValue()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetOpacityMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600F159 RID: 61785
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkCollisionDetectionFilter_GetOpacityMinValue_23(HandleRef pThis);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F15A RID: 61786 RVA: 0x0015052C File Offset: 0x0014E72C
		public virtual float GetOpacityMinValue()
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetOpacityMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600F15B RID: 61787
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_GetTransform_24(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F15C RID: 61788 RVA: 0x0015054C File Offset: 0x0014E74C
		public vtkLinearTransform GetTransform(int i)
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_GetTransform_24(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransform = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransform.Register(null);
				}
			}
			return vtkLinearTransform;
		}

		// Token: 0x0600F15D RID: 61789
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_IntersectPolygonWithPolygon_25(HandleRef pThis, int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol2, IntPtr x1, IntPtr x2, int CollisionMode);

		/// <summary>
		/// Description:
		/// Intersect two polygons, return x1 and x2 as the two points of intersection. If
		/// CollisionMode = VTK_ALL_CONTACTS, both contact points are found. If
		/// CollisionMode = VTK_FIRST_CONTACT or VTK_HALF_CONTACTS, only
		/// one contact point is found.
		/// </summary>
		// Token: 0x0600F15E RID: 61790 RVA: 0x001505BC File Offset: 0x0014E7BC
		public int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol2, IntPtr x1, IntPtr x2, int CollisionMode)
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_IntersectPolygonWithPolygon_25(base.GetCppThis(), npts, pts, bounds, npts2, pts2, bounds2, tol2, x1, x2, CollisionMode);
		}

		// Token: 0x0600F15F RID: 61791
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F160 RID: 61792 RVA: 0x001505EC File Offset: 0x0014E7EC
		public override int IsA(string type)
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x0600F161 RID: 61793
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollisionDetectionFilter_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F162 RID: 61794 RVA: 0x0015060C File Offset: 0x0014E80C
		public new static int IsTypeOf(string type)
		{
			return vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_IsTypeOf_27(type);
		}

		// Token: 0x0600F163 RID: 61795
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F164 RID: 61796 RVA: 0x00150628 File Offset: 0x0014E828
		public new vtkCollisionDetectionFilter NewInstance()
		{
			vtkCollisionDetectionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollisionDetectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F165 RID: 61797
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollisionDetectionFilter_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F166 RID: 61798 RVA: 0x00150684 File Offset: 0x0014E884
		public new static vtkCollisionDetectionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkCollisionDetectionFilter vtkCollisionDetectionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollisionDetectionFilter = (vtkCollisionDetectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollisionDetectionFilter.Register(null);
				}
			}
			return vtkCollisionDetectionFilter;
		}

		// Token: 0x0600F167 RID: 61799
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetBoxTolerance_31(HandleRef pThis, float _arg);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F168 RID: 61800 RVA: 0x00150703 File Offset: 0x0014E903
		public virtual void SetBoxTolerance(float _arg)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetBoxTolerance_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F169 RID: 61801
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetCellTolerance_32(HandleRef pThis, double _arg);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F16A RID: 61802 RVA: 0x00150713 File Offset: 0x0014E913
		public virtual void SetCellTolerance(double _arg)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetCellTolerance_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F16B RID: 61803
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetCollisionMode_33(HandleRef pThis, int _arg);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F16C RID: 61804 RVA: 0x00150723 File Offset: 0x0014E923
		public virtual void SetCollisionMode(int _arg)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetCollisionMode_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F16D RID: 61805
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetCollisionModeToAllContacts_34(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F16E RID: 61806 RVA: 0x00150733 File Offset: 0x0014E933
		public void SetCollisionModeToAllContacts()
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetCollisionModeToAllContacts_34(base.GetCppThis());
		}

		// Token: 0x0600F16F RID: 61807
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetCollisionModeToFirstContact_35(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F170 RID: 61808 RVA: 0x00150742 File Offset: 0x0014E942
		public void SetCollisionModeToFirstContact()
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetCollisionModeToFirstContact_35(base.GetCppThis());
		}

		// Token: 0x0600F171 RID: 61809
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetCollisionModeToHalfContacts_36(HandleRef pThis);

		/// <summary>
		/// two points per collision, or VTK_HALF_CONTACTS to find all the contacting cell pairs
		/// with one point per collision, or VTK_FIRST_CONTACT to quickly find the first contact
		/// point.
		/// </summary>
		// Token: 0x0600F172 RID: 61810 RVA: 0x00150751 File Offset: 0x0014E951
		public void SetCollisionModeToHalfContacts()
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetCollisionModeToHalfContacts_36(base.GetCppThis());
		}

		// Token: 0x0600F173 RID: 61811
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetGenerateScalars_37(HandleRef pThis, int _arg);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F174 RID: 61812 RVA: 0x00150760 File Offset: 0x0014E960
		public virtual void SetGenerateScalars(int _arg)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetGenerateScalars_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F175 RID: 61813
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetInputData_38(HandleRef pThis, int i, HandleRef model);

		/// <summary>
		/// Set and Get the input vtk polydata models
		/// </summary>
		// Token: 0x0600F176 RID: 61814 RVA: 0x00150770 File Offset: 0x0014E970
		public void SetInputData(int i, vtkPolyData model)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetInputData_38(base.GetCppThis(), i, (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		// Token: 0x0600F177 RID: 61815
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetMatrix_39(HandleRef pThis, int i, HandleRef matrix);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F178 RID: 61816 RVA: 0x001507A0 File Offset: 0x0014E9A0
		public void SetMatrix(int i, vtkMatrix4x4 matrix)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetMatrix_39(base.GetCppThis(), i, (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0600F179 RID: 61817
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetNumberOfCellsPerNode_40(HandleRef pThis, int _arg);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F17A RID: 61818 RVA: 0x001507D0 File Offset: 0x0014E9D0
		public virtual void SetNumberOfCellsPerNode(int _arg)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetNumberOfCellsPerNode_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F17B RID: 61819
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetOpacity_41(HandleRef pThis, float _arg);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F17C RID: 61820 RVA: 0x001507E0 File Offset: 0x0014E9E0
		public virtual void SetOpacity(float _arg)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetOpacity_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F17D RID: 61821
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollisionDetectionFilter_SetTransform_42(HandleRef pThis, int i, HandleRef transform);

		/// <summary>
		///  is equivalent to GetOutputPort(2)/GetOutput(2)
		/// </summary>
		// Token: 0x0600F17E RID: 61822 RVA: 0x001507F0 File Offset: 0x0014E9F0
		public void SetTransform(int i, vtkLinearTransform transform)
		{
			vtkCollisionDetectionFilter.vtkCollisionDetectionFilter_SetTransform_42(base.GetCppThis(), i, (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400118E RID: 4494
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollisionDetectionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400118F RID: 4495
		public new static readonly string MRClassNameKey = "class vtkCollisionDetectionFilter";

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0200054C RID: 1356
		public enum CollisionModes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001191 RID: 4497
			VTK_ALL_CONTACTS,
			/// <summary>enum member</summary>
			// Token: 0x04001192 RID: 4498
			VTK_FIRST_CONTACT,
			/// <summary>enum member</summary>
			// Token: 0x04001193 RID: 4499
			VTK_HALF_CONTACTS
		}
	}
}
